namespace Waterbill2.UI
{
    partial class frmUsers
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.ddlRoles = new Telerik.WinControls.UI.RadDropDownList();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtLoginId = new Telerik.WinControls.UI.RadTextBox();
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.rlbRole = new Telerik.WinControls.UI.RadLabel();
            this.rlbActive = new Telerik.WinControls.UI.RadLabel();
            this.rlbLoginId = new Telerik.WinControls.UI.RadLabel();
            this.txtFirstName = new Telerik.WinControls.UI.RadTextBox();
            this.rlbPwd = new Telerik.WinControls.UI.RadLabel();
            this.office2010BlueTheme2 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.rlbFname = new Telerik.WinControls.UI.RadLabel();
            this.radGb2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlActive = new Telerik.WinControls.UI.RadDropDownList();
            this.radGb1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgvSaleDetails = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbLoginId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbFname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGb2)).BeginInit();
            this.radGb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGb1)).BeginInit();
            this.radGb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSaleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Teal;
            this.btnSave.Location = new System.Drawing.Point(263, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 31);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ddlRoles
            // 
            this.ddlRoles.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.ddlRoles.Location = new System.Drawing.Point(161, 156);
            this.ddlRoles.Name = "ddlRoles";
            this.ddlRoles.Size = new System.Drawing.Size(198, 24);
            this.ddlRoles.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = false;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtPassword.Location = new System.Drawing.Point(161, 116);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(198, 24);
            this.txtPassword.TabIndex = 11;
            // 
            // txtLoginId
            // 
            this.txtLoginId.AutoSize = false;
            this.txtLoginId.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtLoginId.Location = new System.Drawing.Point(161, 73);
            this.txtLoginId.Multiline = true;
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(198, 24);
            this.txtLoginId.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Teal;
            this.btnNew.Location = new System.Drawing.Point(154, 250);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 31);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // rlbRole
            // 
            this.rlbRole.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlbRole.ForeColor = System.Drawing.Color.Teal;
            this.rlbRole.Location = new System.Drawing.Point(51, 156);
            this.rlbRole.Name = "rlbRole";
            this.rlbRole.Size = new System.Drawing.Size(36, 22);
            this.rlbRole.TabIndex = 3;
            this.rlbRole.Text = "Role";
            // 
            // rlbActive
            // 
            this.rlbActive.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlbActive.ForeColor = System.Drawing.Color.Teal;
            this.rlbActive.Location = new System.Drawing.Point(51, 198);
            this.rlbActive.Name = "rlbActive";
            this.rlbActive.Size = new System.Drawing.Size(48, 22);
            this.rlbActive.TabIndex = 4;
            this.rlbActive.Text = "Active";
            // 
            // rlbLoginId
            // 
            this.rlbLoginId.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlbLoginId.ForeColor = System.Drawing.Color.Teal;
            this.rlbLoginId.Location = new System.Drawing.Point(51, 73);
            this.rlbLoginId.Name = "rlbLoginId";
            this.rlbLoginId.Size = new System.Drawing.Size(63, 22);
            this.rlbLoginId.TabIndex = 1;
            this.rlbLoginId.Text = "Login ID";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoSize = false;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtFirstName.Location = new System.Drawing.Point(161, 33);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(198, 24);
            this.txtFirstName.TabIndex = 1;
            // 
            // rlbPwd
            // 
            this.rlbPwd.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlbPwd.ForeColor = System.Drawing.Color.Teal;
            this.rlbPwd.Location = new System.Drawing.Point(51, 116);
            this.rlbPwd.Name = "rlbPwd";
            this.rlbPwd.Size = new System.Drawing.Size(70, 22);
            this.rlbPwd.TabIndex = 2;
            this.rlbPwd.Text = "Password";
            // 
            // rlbFname
            // 
            this.rlbFname.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlbFname.ForeColor = System.Drawing.Color.Teal;
            this.rlbFname.Location = new System.Drawing.Point(51, 33);
            this.rlbFname.Name = "rlbFname";
            this.rlbFname.Size = new System.Drawing.Size(79, 22);
            this.rlbFname.TabIndex = 0;
            this.rlbFname.Text = "First Name";
            // 
            // radGb2
            // 
            this.radGb2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGb2.Controls.Add(this.radButton1);
            this.radGb2.Controls.Add(this.ddlActive);
            this.radGb2.Controls.Add(this.btnSave);
            this.radGb2.Controls.Add(this.ddlRoles);
            this.radGb2.Controls.Add(this.txtPassword);
            this.radGb2.Controls.Add(this.txtLoginId);
            this.radGb2.Controls.Add(this.btnNew);
            this.radGb2.Controls.Add(this.rlbRole);
            this.radGb2.Controls.Add(this.rlbActive);
            this.radGb2.Controls.Add(this.rlbLoginId);
            this.radGb2.Controls.Add(this.rlbPwd);
            this.radGb2.Controls.Add(this.txtFirstName);
            this.radGb2.Controls.Add(this.rlbFname);
            this.radGb2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGb2.ForeColor = System.Drawing.Color.Teal;
            this.radGb2.HeaderText = "Add New User";
            this.radGb2.Location = new System.Drawing.Point(511, 12);
            this.radGb2.Name = "radGb2";
            this.radGb2.Size = new System.Drawing.Size(419, 294);
            this.radGb2.TabIndex = 3;
            this.radGb2.Text = "Add New User";
            // 
            // ddlActive
            // 
            this.ddlActive.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.ddlActive.Location = new System.Drawing.Point(161, 198);
            this.ddlActive.Name = "ddlActive";
            this.ddlActive.Size = new System.Drawing.Size(198, 24);
            this.ddlActive.TabIndex = 14;
            // 
            // radGb1
            // 
            this.radGb1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGb1.Controls.Add(this.rgvSaleDetails);
            this.radGb1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGb1.ForeColor = System.Drawing.Color.Teal;
            this.radGb1.HeaderText = " Users List";
            this.radGb1.Location = new System.Drawing.Point(12, 12);
            this.radGb1.Name = "radGb1";
            this.radGb1.Size = new System.Drawing.Size(493, 294);
            this.radGb1.TabIndex = 4;
            this.radGb1.Text = " Users List";
            // 
            // rgvSaleDetails
            // 
            this.rgvSaleDetails.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgvSaleDetails.Location = new System.Drawing.Point(14, 21);
            // 
            // 
            // 
            this.rgvSaleDetails.MasterTemplate.AllowAddNewRow = false;
            this.rgvSaleDetails.MasterTemplate.AllowCellContextMenu = false;
            this.rgvSaleDetails.MasterTemplate.AllowColumnChooser = false;
            this.rgvSaleDetails.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.rgvSaleDetails.MasterTemplate.AllowColumnReorder = false;
            this.rgvSaleDetails.MasterTemplate.AllowColumnResize = false;
            this.rgvSaleDetails.MasterTemplate.AllowDeleteRow = false;
            this.rgvSaleDetails.MasterTemplate.AllowDragToGroup = false;
            this.rgvSaleDetails.MasterTemplate.AllowRowResize = false;
            this.rgvSaleDetails.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.HeaderText = "UserId";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.Name = "column3";
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.HeaderText = "User Name";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 190;
            gridViewTextBoxColumn4.HeaderText = "Is Active";
            gridViewTextBoxColumn4.Name = "column7";
            gridViewTextBoxColumn4.Width = 70;
            this.rgvSaleDetails.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.rgvSaleDetails.MasterTemplate.EnableGrouping = false;
            this.rgvSaleDetails.MasterTemplate.EnableSorting = false;
            this.rgvSaleDetails.MasterTemplate.ShowFilteringRow = false;
            this.rgvSaleDetails.MasterTemplate.ShowHeaderCellButtons = true;
            this.rgvSaleDetails.MasterTemplate.ShowRowHeaderColumn = false;
            this.rgvSaleDetails.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvSaleDetails.Name = "rgvSaleDetails";
            this.rgvSaleDetails.ShowGroupPanel = false;
            this.rgvSaleDetails.ShowHeaderCellButtons = true;
            this.rgvSaleDetails.Size = new System.Drawing.Size(461, 260);
            this.rgvSaleDetails.TabIndex = 60;
            this.rgvSaleDetails.Text = "radGridView1";
            this.rgvSaleDetails.UseCompatibleTextRendering = false;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radButton1.ForeColor = System.Drawing.Color.Teal;
            this.radButton1.Location = new System.Drawing.Point(45, 250);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(103, 31);
            this.radButton1.TabIndex = 15;
            this.radButton1.Text = "Delete";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 325);
            this.Controls.Add(this.radGb1);
            this.Controls.Add(this.radGb2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUsers";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmUsers";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbLoginId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbFname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGb2)).EndInit();
            this.radGb2.ResumeLayout(false);
            this.radGb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGb1)).EndInit();
            this.radGb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvSaleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadDropDownList ddlRoles;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtLoginId;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadLabel rlbRole;
        private Telerik.WinControls.UI.RadLabel rlbActive;
        private Telerik.WinControls.UI.RadLabel rlbLoginId;
        private Telerik.WinControls.UI.RadTextBox txtFirstName;
        private Telerik.WinControls.UI.RadLabel rlbPwd;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme2;
        private Telerik.WinControls.UI.RadLabel rlbFname;
        private Telerik.WinControls.UI.RadGroupBox radGb2;
        private Telerik.WinControls.UI.RadGroupBox radGb1;
        private Telerik.WinControls.UI.RadDropDownList ddlActive;
        private Telerik.WinControls.UI.RadGridView rgvSaleDetails;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
