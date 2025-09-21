namespace EmployeeManagement.src.EmployeeApp.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvEmployees = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbDepartmentFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnReport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartmentFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(20, 97);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(689, 181);
            this.dgvEmployees.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.dgvEmployees.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.dgvEmployees.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvEmployees.StateCommon.DataCell.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmployees.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployees.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmployees.StateSelected.DataCell.Back.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmployees.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 48);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 41);
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.SpringGreen;
            this.txtSearch.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 18;
            this.txtSearch.StateCommon.Border.Width = 2;
            this.txtSearch.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search Employee";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            // 
            // cmbDepartmentFilter
            // 
            this.cmbDepartmentFilter.DropDownWidth = 150;
            this.cmbDepartmentFilter.Location = new System.Drawing.Point(545, 48);
            this.cmbDepartmentFilter.Margin = new System.Windows.Forms.Padding(5);
            this.cmbDepartmentFilter.Name = "cmbDepartmentFilter";
            this.cmbDepartmentFilter.Size = new System.Drawing.Size(164, 32);
            this.cmbDepartmentFilter.StateActive.ComboBox.Content.Padding = new System.Windows.Forms.Padding(3);
            this.cmbDepartmentFilter.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.cmbDepartmentFilter.StateCommon.ComboBox.Border.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbDepartmentFilter.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbDepartmentFilter.StateCommon.ComboBox.Border.Rounding = 15;
            this.cmbDepartmentFilter.StateCommon.ComboBox.Content.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.cmbDepartmentFilter.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Montserrat ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentFilter.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(5);
            this.cmbDepartmentFilter.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbDepartmentFilter.StateCommon.Item.Border.Rounding = 12;
            this.cmbDepartmentFilter.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentFilter.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartmentFilter.TabIndex = 2;
            this.cmbDepartmentFilter.Text = "Select Department";
            this.cmbDepartmentFilter.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmentFilter_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(20, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 34);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.SpringGreen;
            this.btnAdd.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.Rounding = 15;
            this.btnAdd.StateCommon.Border.Width = 2;
            this.btnAdd.StateCommon.Content.Padding = new System.Windows.Forms.Padding(1);
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SpringGreen;
            this.btnAdd.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Values.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(588, 298);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(121, 34);
            this.btnExport.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnExport.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnExport.StateCommon.Border.Color1 = System.Drawing.Color.SpringGreen;
            this.btnExport.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExport.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExport.StateCommon.Border.Rounding = 15;
            this.btnExport.StateCommon.Border.Width = 2;
            this.btnExport.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SpringGreen;
            this.btnExport.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.TabIndex = 4;
            this.btnExport.Values.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Location = new System.Drawing.Point(444, 298);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(113, 34);
            this.btnReport.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnReport.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnReport.StateCommon.Border.Color1 = System.Drawing.Color.SpringGreen;
            this.btnReport.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReport.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReport.StateCommon.Border.Rounding = 15;
            this.btnReport.StateCommon.Border.Width = 2;
            this.btnReport.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SpringGreen;
            this.btnReport.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.TabIndex = 5;
            this.btnReport.Values.Text = "Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(306, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.SpringGreen;
            this.btnDelete.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 15;
            this.btnDelete.StateCommon.Border.Width = 2;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SpringGreen;
            this.btnDelete.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(167, 298);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 34);
            this.btnEdit.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnEdit.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnEdit.StateCommon.Border.Color1 = System.Drawing.Color.SpringGreen;
            this.btnEdit.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEdit.StateCommon.Border.Rounding = 15;
            this.btnEdit.StateCommon.Border.Width = 2;
            this.btnEdit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.SpringGreen;
            this.btnEdit.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Values.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.ColorMap = System.Drawing.Color.Transparent;
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = global::EmployeeManagement.Properties.Resources.close2;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::EmployeeManagement.Properties.Resources.close2;
            this.kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::EmployeeManagement.Properties.Resources.close2;
            this.kryptonPalette1.ButtonSpecs.FormMax.ColorMap = System.Drawing.Color.Transparent;
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = global::EmployeeManagement.Properties.Resources.max1;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::EmployeeManagement.Properties.Resources.max1;
            this.kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::EmployeeManagement.Properties.Resources.max1;
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = global::EmployeeManagement.Properties.Resources.mini1;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::EmployeeManagement.Properties.Resources.mini1;
            this.kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::EmployeeManagement.Properties.Resources.mini1;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BackgroundImage = global::EmployeeManagement.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 364);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbDepartmentFilter);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvEmployees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartmentFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEmployees;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbDepartmentFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExport;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReport;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}