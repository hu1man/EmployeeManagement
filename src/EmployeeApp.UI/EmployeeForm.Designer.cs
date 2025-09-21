namespace EmployeeManagement.src.EmployeeApp.UI
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.lblName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblEmail = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDepartment = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbDepartment = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dtpJoiningDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.lblJoiningDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numSalary = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lblSalary = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbEmployeeType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblEmployeeType = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numHourlyRate = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lblHourlyRate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.numHoursPerWeek = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lblHoursPerWeek = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployeeType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(68, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 22);
            this.lblName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblName.StateCommon.ShortText.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.TabIndex = 0;
            this.lblName.Values.Text = "Name";
            this.lblName.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel1_Paint);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 32);
            this.txtName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtName.StateCommon.Border.Rounding = 15;
            this.txtName.StateCommon.Content.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 32);
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 15;
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Email";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(68, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 22);
            this.lblEmail.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblEmail.StateCommon.ShortText.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Values.Text = "Email";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(18, 162);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(111, 22);
            this.lblDepartment.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblDepartment.StateCommon.ShortText.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Values.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownWidth = 121;
            this.cmbDepartment.Location = new System.Drawing.Point(152, 154);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(181, 29);
            this.cmbDepartment.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbDepartment.StateCommon.ComboBox.Border.Rounding = 15;
            this.cmbDepartment.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.TabIndex = 5;
            this.cmbDepartment.Text = "All";
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoiningDate.Location = new System.Drawing.Point(152, 196);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(181, 30);
            this.dtpJoiningDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpJoiningDate.StateCommon.Border.Rounding = 15;
            this.dtpJoiningDate.StateCommon.Content.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoiningDate.TabIndex = 6;
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.Location = new System.Drawing.Point(35, 196);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(90, 22);
            this.lblJoiningDate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblJoiningDate.StateCommon.ShortText.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.TabIndex = 7;
            this.lblJoiningDate.Values.Text = "Join Date";
            // 
            // numSalary
            // 
            this.numSalary.Location = new System.Drawing.Point(511, 62);
            this.numSalary.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(180, 30);
            this.numSalary.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.numSalary.StateCommon.Border.Rounding = 15;
            this.numSalary.StateCommon.Content.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSalary.TabIndex = 8;
            this.numSalary.ValueChanged += new System.EventHandler(this.numSalary_ValueChanged);
            // 
            // lblSalary
            // 
            this.lblSalary.Location = new System.Drawing.Point(420, 71);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(62, 22);
            this.lblSalary.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblSalary.StateCommon.ShortText.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.TabIndex = 9;
            this.lblSalary.Values.Text = "Salary";
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.DropDownWidth = 121;
            this.cmbEmployeeType.Items.AddRange(new object[] {
            "Select Employee Type",
            "FullTimeEmployee",
            "PartTimeEmployee"});
            this.cmbEmployeeType.Location = new System.Drawing.Point(510, 105);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(181, 29);
            this.cmbEmployeeType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbEmployeeType.StateCommon.ComboBox.Border.Rounding = 15;
            this.cmbEmployeeType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeType.TabIndex = 10;
            this.cmbEmployeeType.Text = "Select Employee Type";
            this.cmbEmployeeType.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeType_SelectedIndexChanged_1);
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.Location = new System.Drawing.Point(347, 113);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(140, 22);
            this.lblEmployeeType.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblEmployeeType.StateCommon.ShortText.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeType.TabIndex = 11;
            this.lblEmployeeType.Values.Text = "Employee Type";
            // 
            // numHourlyRate
            // 
            this.numHourlyRate.Location = new System.Drawing.Point(510, 143);
            this.numHourlyRate.Name = "numHourlyRate";
            this.numHourlyRate.Size = new System.Drawing.Size(181, 30);
            this.numHourlyRate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.numHourlyRate.StateCommon.Border.Rounding = 15;
            this.numHourlyRate.StateCommon.Content.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHourlyRate.TabIndex = 12;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.Location = new System.Drawing.Point(374, 152);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(109, 22);
            this.lblHourlyRate.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblHourlyRate.StateCommon.ShortText.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.TabIndex = 13;
            this.lblHourlyRate.Values.Text = "Hourly Rate";
            // 
            // numHoursPerWeek
            // 
            this.numHoursPerWeek.Location = new System.Drawing.Point(511, 194);
            this.numHoursPerWeek.Name = "numHoursPerWeek";
            this.numHoursPerWeek.Size = new System.Drawing.Size(180, 30);
            this.numHoursPerWeek.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.numHoursPerWeek.StateCommon.Border.Rounding = 15;
            this.numHoursPerWeek.StateCommon.Content.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHoursPerWeek.TabIndex = 14;
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.Location = new System.Drawing.Point(360, 203);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(127, 22);
            this.lblHoursPerWeek.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblHoursPerWeek.StateCommon.ShortText.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursPerWeek.TabIndex = 15;
            this.lblHoursPerWeek.Values.Text = "Hours P.Week";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.SpringGreen;
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 15;
            this.btnSave.StateCommon.Border.Width = 2;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SpringGreen;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 16;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(389, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCancel.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCancel.StateCommon.Border.Color1 = System.Drawing.Color.SpringGreen;
            this.btnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.Rounding = 15;
            this.btnCancel.StateCommon.Border.Width = 2;
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SpringGreen;
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::EmployeeManagement.Properties.Resources.close2;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::EmployeeManagement.Properties.Resources.close2;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::EmployeeManagement.Properties.Resources.close2;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::EmployeeManagement.Properties.Resources.max1;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::EmployeeManagement.Properties.Resources.max1;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::EmployeeManagement.Properties.Resources.max1;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::EmployeeManagement.Properties.Resources.mini1;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::EmployeeManagement.Properties.Resources.mini1;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::EmployeeManagement.Properties.Resources.mini1;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::EmployeeManagement.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 364);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHoursPerWeek);
            this.Controls.Add(this.numHoursPerWeek);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.numHourlyRate);
            this.Controls.Add(this.lblEmployeeType);
            this.Controls.Add(this.cmbEmployeeType);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.numSalary);
            this.Controls.Add(this.lblJoiningDate);
            this.Controls.Add(this.dtpJoiningDate);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployeeType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDepartment;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbDepartment;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpJoiningDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblJoiningDate;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSalary;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbEmployeeType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblEmployeeType;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numHourlyRate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblHourlyRate;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numHoursPerWeek;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblHoursPerWeek;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}