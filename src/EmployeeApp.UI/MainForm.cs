using EmployeeApp.UI;
using EmployeeManagement.src.EmployeeApp.Core.Interfaces;
using EmployeeManagement.src.EmployeeApp.Core.Models;
using EmployeeManagement.src.EmployeeApp.Data.Repositories;
using EmployeeManagement.src.EmployeeApp.UI.Models;
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
    public partial class MainForm : KryptonForm
    {
        private readonly IEmployeeRepository _repo;
        private BindingSource _bs = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(IEmployeeRepository repo) : this()
        {
            _repo = repo;
            dgvEmployees.AutoGenerateColumns = false;
            SetupGridColumns();
        }

        private void SetupGridColumns()
        {
            dgvEmployees.Columns.Clear();
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.MultiSelect = false;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.ReadOnly = true;

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Visible = false
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colName",
                HeaderText = "Name",
                DataPropertyName = "Name",
                Width = 200
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEmail",
                HeaderText = "Email",
                DataPropertyName = "Email",
                Width = 200
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDeptName",
                HeaderText = "Department",
                DataPropertyName = "DepartmentName",
                Width = 150
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colJoin",
                HeaderText = "Join Date",
                DataPropertyName = "JoiningDate",
                Width = 100
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSalary",
                HeaderText = "Salary",
                DataPropertyName = "Salary",
                Width = 90,
                DefaultCellStyle = { Format = "C2" }
            });
        }

        private async Task LoadEmployeesAsync()
        {
            try
            {
                var items = await _repo.GetAllAsync();

                var dtoList = items.Select(e => new EmployeeDto
                {
                    Id = e.Id,
                    Name = e.Name ?? "",
                    Email = e.Email ?? "",
                    DepartmentName = e.Department?.Name ?? "Unassigned",
                    JoiningDate = e.JoiningDate.ToString("MM/dd/yyyy"),
                    Salary = e.CalculateMonthlyPay()  // Using CalculateMonthlyPay instead of direct Salary
                }).ToList();

                _bs.DataSource = null;  // Clear the binding source first
                _bs.DataSource = dtoList;
                dgvEmployees.DataSource = _bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var term = txtSearch.Text.Trim();
                if (string.IsNullOrEmpty(term))
                {
                    await LoadEmployeesAsync();  // Reset to full list if search is empty
                    return;
                }

                var results = await _repo.SearchAsync(term);
                var dtoList = results.Select(p => new EmployeeDto
                {
                    Id = p.Id,
                    Name = p.Name ?? "",
                    Email = p.Email ?? "",
                    DepartmentName = p.Department?.Name ?? "Unassigned",
                    JoiningDate = p.JoiningDate.ToString("MM/dd/yyyy"),
                    Salary = p.CalculateMonthlyPay()  // Using CalculateMonthlyPay instead of direct Salary
                }).ToList();

                _bs.DataSource = null;  // Clear the binding source first
                _bs.DataSource = dtoList;
                dgvEmployees.DataSource = _bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
            }
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadDepartmentsAsync();
            await LoadEmployeesAsync();

        }

        private async Task LoadDepartmentsAsync()
        {
            try
            {
                var depts = await _repo.GetDepartmentsAsync();
                var list = new List<Department>();
                list.Add(new Department { Id = 0, Name = "All" });
                list.AddRange(depts);
                cmbDepartmentFilter.DataSource = list;
                cmbDepartmentFilter.DisplayMember = "Name";
                cmbDepartmentFilter.ValueMember = "Id";
            }
            catch (Exception ex) { MessageBox.Show("Error loading departments: " + ex.Message); }
        }
        private async void cmbDepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedDept = cmbDepartmentFilter.SelectedItem as Department;
                if (selectedDept == null || selectedDept.Id == 0)
                {
                    await LoadEmployeesAsync(); // Show all
                }
                else
                {
                    var allEmployees = await _repo.GetAllAsync();
                    var filtered = allEmployees
                        .Where(p => p.DepartmentId == selectedDept.Id)
                        .Select(p => new EmployeeDto
                        {
                            Id = p.Id,
                            Name = p.Name ?? "",
                            Email = p.Email ?? "",
                            DepartmentName = p.Department?.Name ?? "Unassigned",
                            JoiningDate = p.JoiningDate.ToString("MM/dd/yyyy"),
                            Salary = p.CalculateMonthlyPay()
                        })
                        .ToList();

                    _bs.DataSource = null;
                    _bs.DataSource = filtered;
                    dgvEmployees.DataSource = _bs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Department filter error: {ex.Message}");
            }
        }

        private async void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var frm = new EmployeeForm(_repo);
                var result = frm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    await LoadEmployeesAsync();
                    MessageBox.Show("Employee added successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add error: {ex.Message}");
            }
        }

        private async void btnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.CurrentRow == null)
                {
                    MessageBox.Show("Please select an employee to edit.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var dto = dgvEmployees.CurrentRow.DataBoundItem as EmployeeDto;
                if (dto == null)
                {
                    MessageBox.Show("Invalid employee selection.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var emp = await _repo.GetByIdAsync(dto.Id);
                if (emp == null)
                {
                    MessageBox.Show("Employee not found in database.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await LoadEmployeesAsync(); // Refresh grid as data might be out of sync
                    return;
                }

                var frm = new EmployeeForm(_repo, emp);
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    await LoadEmployeesAsync();
                    MessageBox.Show("Employee updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while editing employee: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.CurrentRow == null) return;

                var dto = dgvEmployees.CurrentRow.DataBoundItem as EmployeeDto;
                if (dto == null) return;

                var result = MessageBox.Show("Are you sure you want to delete this selected Employee?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result != DialogResult.Yes) return;

                await _repo.DeleteAsync(dto.Id);
                await LoadEmployeesAsync();
                MessageBox.Show("Employee deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Delete error: {ex.Message}");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvEmployees.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.CurrentCell = null;
            dgvEmployees.SelectedCells.Equals(null);
            dgvEmployees.SelectedColumns.Equals(null);
            dgvEmployees.SelectedRows.Equals(null);
            dgvEmployees.ClearSelection();
        }

        private async void btnReport_Click_1(object sender, EventArgs e)
        {
            var dict = await _repo.GetTotalSalaryByDepartmentAsync();
            // Simple report in messagebox or new form
            var lines = new System.Text.StringBuilder();
            lines.AppendLine("Department | Total Salary");
            lines.AppendLine("--------------------------------");
            foreach (var kv in dict) lines.AppendLine($"{kv.Key} - {kv.Value:C}\n");  
            MessageBox.Show(lines.ToString(), "Total Salary by Department");
        }

        private async void btnExport_Click_1(object sender, EventArgs e)
        {
            try
            {
                var items = await _repo.GetAllAsync();
                var sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "employees.csv" };
                if (sfd.ShowDialog(this) != DialogResult.OK) return;
                CsvExportHelper.ExportEmployeesToCsv(items, sfd.FileName);
                MessageBox.Show("Export completed.");
            }
            catch (Exception ex) { MessageBox.Show("Export error: " + ex.Message); }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
    }

}


