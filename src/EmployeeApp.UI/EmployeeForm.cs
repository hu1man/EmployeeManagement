using EmployeeApp.Core.Models;
using EmployeeManagement.src.EmployeeApp.Core.Interfaces;
using EmployeeManagement.src.EmployeeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace EmployeeManagement.src.EmployeeApp.UI
{
    public partial class EmployeeForm : KryptonForm
    {
        private readonly IEmployeeRepository _repo;
        private Employee _editing;
        public EmployeeForm(IEmployeeRepository repo, Employee editing = null)
        {
            InitializeComponent();
            _repo = repo;
            _editing = editing;
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadDepartmentsAsync();
            if (_editing != null)
            {
                LoadForEdit();
            }
            else
            {
                if (cmbEmployeeType.Items.Count > 0)
                    cmbEmployeeType.SelectedIndex = 0;
                if (cmbDepartment.Items.Count > 0)
                    cmbDepartment.SelectedIndex = 0;
                dtpJoiningDate.Value = DateTime.Now;
            }

            // Attach handlers to clear textboxes on focus
            txtName.GotFocus += (s, ev) => txtName.Clear();
            txtEmail.GotFocus += (s, ev) => txtEmail.Clear();
        }

        private async Task LoadDepartmentsAsync()
        {
            var depts = await _repo.GetDepartmentsAsync();
            cmbDepartment.DataSource = depts;
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";
        }

        private void LoadForEdit()
        {
            if (_editing == null) return;

            Text = "Edit Employee"; // Set form title to indicate edit mode
            txtName.Text = _editing.Name;
            txtEmail.Text = _editing.Email;
            dtpJoiningDate.Value = _editing.JoiningDate;
            numSalary.Value = _editing.Salary;
            if (_editing.DepartmentId.HasValue)
                cmbDepartment.SelectedValue = _editing.DepartmentId.Value;

            if (_editing is PartTimeEmployee pt)
            {
                cmbEmployeeType.SelectedItem = "PartTime";
                numHourlyRate.Value = pt.HourlyRate;
                numHoursPerWeek.Value = pt.HoursPerWeek;
            }
            else
            {
                cmbEmployeeType.SelectedItem = "FullTime";
            }

            TogglePartTimeFields();
            
            // Remove the clear-on-focus behavior in edit mode
            txtName.GotFocus -= (s, ev) => txtName.Clear();
            txtEmail.GotFocus -= (s, ev) => txtEmail.Clear();
        }

        private void cmbEmployeeType_SelectedIndexChanged(object sender, EventArgs e) => TogglePartTimeFields();

        private void TogglePartTimeFields()
        {
            bool isPart = (cmbEmployeeType.SelectedItem?.ToString() == "PartTime");
            lblHourlyRate.Visible = numHourlyRate.Visible = isPart;
            lblHoursPerWeek.Visible = numHoursPerWeek.Visible = isPart;
        }

        
        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            cmbEmployeeType.SelectedItem = "Select Employee Type";
        }

        private void cmbEmployeeType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Only enable/disable part-time controls, do NOT change numSalary.Value
            if (cmbEmployeeType.SelectedItem != null && cmbEmployeeType.SelectedItem.ToString() == "FullTimeEmployee")
            {
                numHourlyRate.Enabled = false;
                numHoursPerWeek.Enabled = false;
            }
            else
            {
                numHourlyRate.Enabled = true;
                numHoursPerWeek.Enabled = true;
            }
            // Do NOT set numSalary.Value here!
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var confirm = MessageBox.Show(
                _editing == null 
                    ? "Are you sure you want to save these details to the database?" 
                    : "Are you sure you want to update this employee's details?",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
            {
                if (_editing == null) // Only reset fields if not in edit mode
                {
                    ResetForm();
                }
                return;
            }

            try
            {
                if (_editing == null)
                {
                    await SaveNewEmployee();
                }
                else
                {
                    await UpdateExistingEmployee();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (cmbDepartment.SelectedItem == null)
            {
                MessageBox.Show("Department required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartment.Focus();
                return false;
            }
            if (numSalary.Value <= 0)
            {
                MessageBox.Show("Salary must be greater than 0", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSalary.Focus();
                return false;
            }
            if (cmbEmployeeType.SelectedItem == null)
            {
                MessageBox.Show("Employee type required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEmployeeType.Focus();
                return false;
            }
            if (cmbEmployeeType.SelectedItem.ToString() == "PartTime")
            {
                if (numHourlyRate.Value <= 0)
                {
                    MessageBox.Show("Hourly rate must be greater than 0", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numHourlyRate.Focus();
                    return false;
                }
                if (numHoursPerWeek.Value <= 0)
                {
                    MessageBox.Show("Hours per week must be greater than 0", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numHoursPerWeek.Focus();
                    return false;
                }
            }
            return true;
        }

        private void ResetForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            numSalary.Value = numSalary.Minimum;
            numHourlyRate.Value = numHourlyRate.Minimum;
            numHoursPerWeek.Value = numHoursPerWeek.Minimum;
            dtpJoiningDate.Value = DateTime.Now;
            if (cmbEmployeeType.Items.Count > 0) cmbEmployeeType.SelectedIndex = 0;
            if (cmbDepartment.Items.Count > 0) cmbDepartment.SelectedIndex = 0;
        }

        private async Task SaveNewEmployee()
        {
            Employee eobj;
            if (cmbEmployeeType.SelectedItem?.ToString() == "PartTime")
            {
                eobj = new PartTimeEmployee
                {
                    HourlyRate = numHourlyRate.Value,
                    HoursPerWeek = (int)numHoursPerWeek.Value
                };
            }
            else
                eobj = new FullTimeEmployee();

            eobj.Name = txtName.Text.Trim();
            eobj.Email = txtEmail.Text.Trim();
            eobj.JoiningDate = dtpJoiningDate.Value;
            eobj.Salary = numSalary.Value;
            eobj.DepartmentId = (cmbDepartment.SelectedItem as Department)?.Id;

            await _repo.AddAsync(eobj);
        }

        private async Task UpdateExistingEmployee()
        {
            // Handle employee type conversion if needed
            if (_editing is PartTimeEmployee && cmbEmployeeType.SelectedItem?.ToString() == "PartTime")
            {
                var p = _editing as PartTimeEmployee;
                p.HourlyRate = numHourlyRate.Value;
                p.HoursPerWeek = (int)numHoursPerWeek.Value;
            }
            else if (_editing is PartTimeEmployee && cmbEmployeeType.SelectedItem?.ToString() == "FullTime")
            {
                // Convert part-time to full-time
                _editing = new FullTimeEmployee { Id = _editing.Id };
            }
            else if (_editing is FullTimeEmployee && cmbEmployeeType.SelectedItem?.ToString() == "PartTime")
            {
                // Convert full-time to part-time
                _editing = new PartTimeEmployee 
                { 
                    Id = _editing.Id,
                    HourlyRate = numHourlyRate.Value,
                    HoursPerWeek = (int)numHoursPerWeek.Value
                };
            }

            _editing.Name = txtName.Text.Trim();
            _editing.Email = txtEmail.Text.Trim();
            _editing.JoiningDate = dtpJoiningDate.Value;
            _editing.Salary = numSalary.Value;
            _editing.DepartmentId = (cmbDepartment.SelectedItem as Department)?.Id;

            await _repo.UpdateAsync(_editing);
        }

        private void numSalary_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

