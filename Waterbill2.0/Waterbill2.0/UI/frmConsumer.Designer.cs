namespace Waterbill2.UI
{
    partial class frmConsumer
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGb1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgvUsers = new Telerik.WinControls.UI.RadGridView();
            this.radGb2 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtConsumerNo = new Telerik.WinControls.UI.RadTextBox();
            this.txtType = new Telerik.WinControls.UI.RadTextBox();
            this.btnNew = new Telerik.WinControls.UI.RadButton();
            this.ddlActive = new Telerik.WinControls.UI.RadDropDownList();
            this.lblMeter = new Telerik.WinControls.UI.RadLabel();
            this.rlbActive = new Telerik.WinControls.UI.RadLabel();
            this.lbType = new Telerik.WinControls.UI.RadLabel();
            this.lblCNo = new Telerik.WinControls.UI.RadLabel();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.lbname = new Telerik.WinControls.UI.RadLabel();
            this.txtMeterNo = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGb1)).BeginInit();
            this.radGb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGb2)).BeginInit();
            this.radGb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsumerNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeterNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGb1
            // 
            this.radGb1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGb1.Controls.Add(this.rgvUsers);
            this.radGb1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGb1.ForeColor = System.Drawing.Color.Teal;
            this.radGb1.HeaderText = " Users List";
            this.radGb1.Location = new System.Drawing.Point(12, 12);
            this.radGb1.Name = "radGb1";
            this.radGb1.Size = new System.Drawing.Size(493, 294);
            this.radGb1.TabIndex = 3;
            this.radGb1.Text = " Users List";
            // 
            // rgvUsers
            // 
            this.rgvUsers.AutoSizeRows = true;
            this.rgvUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgvUsers.Location = new System.Drawing.Point(14, 21);
            // 
            // 
            // 
            this.rgvUsers.MasterTemplate.AllowAddNewRow = false;
            this.rgvUsers.MasterTemplate.AllowCellContextMenu = false;
            this.rgvUsers.MasterTemplate.AllowDeleteRow = false;
            this.rgvUsers.MasterTemplate.AllowDragToGroup = false;
            this.rgvUsers.MasterTemplate.AllowEditRow = false;
            this.rgvUsers.MasterTemplate.AllowRowResize = false;
            this.rgvUsers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.HeaderText = "User";
            gridViewTextBoxColumn5.Name = "column3";
            gridViewTextBoxColumn5.Width = 115;
            gridViewTextBoxColumn6.AllowFiltering = false;
            gridViewTextBoxColumn6.AllowGroup = false;
            gridViewTextBoxColumn6.AllowHide = false;
            gridViewTextBoxColumn6.AllowReorder = false;
            gridViewTextBoxColumn6.HeaderText = "Username";
            gridViewTextBoxColumn6.Name = "username";
            gridViewTextBoxColumn6.RowSpan = 25;
            gridViewTextBoxColumn6.Width = 163;
            gridViewTextBoxColumn7.HeaderText = "Role";
            gridViewTextBoxColumn7.Name = "column2";
            gridViewTextBoxColumn7.Width = 116;
            gridViewTextBoxColumn8.HeaderText = "Active";
            gridViewTextBoxColumn8.Name = "column1";
            gridViewTextBoxColumn8.Width = 51;
            this.rgvUsers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.rgvUsers.MasterTemplate.EnableGrouping = false;
            this.rgvUsers.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.rgvUsers.Name = "rgvUsers";
            this.rgvUsers.Size = new System.Drawing.Size(462, 260);
            this.rgvUsers.TabIndex = 0;
            // 
            // radGb2
            // 
            this.radGb2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGb2.Controls.Add(this.txtMeterNo);
            this.radGb2.Controls.Add(this.btnSave);
            this.radGb2.Controls.Add(this.txtConsumerNo);
            this.radGb2.Controls.Add(this.txtType);
            this.radGb2.Controls.Add(this.btnNew);
            this.radGb2.Controls.Add(this.ddlActive);
            this.radGb2.Controls.Add(this.lblMeter);
            this.radGb2.Controls.Add(this.rlbActive);
            this.radGb2.Controls.Add(this.lbType);
            this.radGb2.Controls.Add(this.lblCNo);
            this.radGb2.Controls.Add(this.txtName);
            this.radGb2.Controls.Add(this.lbname);
            this.radGb2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGb2.ForeColor = System.Drawing.Color.Teal;
            this.radGb2.HeaderText = "Add New User";
            this.radGb2.Location = new System.Drawing.Point(516, 23);
            this.radGb2.Name = "radGb2";
            this.radGb2.Size = new System.Drawing.Size(461, 293);
            this.radGb2.TabIndex = 4;
            this.radGb2.Text = "Add New User";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Teal;
            this.btnSave.Location = new System.Drawing.Point(268, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 31);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            // 
            // txtConsumerNo
            // 
            this.txtConsumerNo.AutoSize = false;
            this.txtConsumerNo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtConsumerNo.Location = new System.Drawing.Point(203, 116);
            this.txtConsumerNo.Multiline = true;
            this.txtConsumerNo.Name = "txtConsumerNo";
            this.txtConsumerNo.PasswordChar = '*';
            this.txtConsumerNo.Size = new System.Drawing.Size(198, 24);
            this.txtConsumerNo.TabIndex = 11;
            // 
            // txtType
            // 
            this.txtType.AutoSize = false;
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtType.Location = new System.Drawing.Point(203, 73);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(198, 24);
            this.txtType.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.Teal;
            this.btnNew.Location = new System.Drawing.Point(147, 249);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 31);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            // 
            // ddlActive
            // 
            this.ddlActive.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.ddlActive.Location = new System.Drawing.Point(203, 198);
            this.ddlActive.Name = "ddlActive";
            this.ddlActive.Size = new System.Drawing.Size(198, 24);
            this.ddlActive.TabIndex = 9;
            // 
            // lblMeter
            // 
            this.lblMeter.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeter.ForeColor = System.Drawing.Color.Teal;
            this.lblMeter.Location = new System.Drawing.Point(51, 156);
            this.lblMeter.Name = "lblMeter";
            this.lblMeter.Size = new System.Drawing.Size(105, 22);
            this.lblMeter.TabIndex = 3;
            this.lblMeter.Text = "Meter Number";
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
            // lbType
            // 
            this.lbType.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.Teal;
            this.lbType.Location = new System.Drawing.Point(51, 73);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(145, 22);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "Consumer/Emlpoyee";
            // 
            // lblCNo
            // 
            this.lblCNo.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNo.ForeColor = System.Drawing.Color.Teal;
            this.lblCNo.Location = new System.Drawing.Point(51, 116);
            this.lblCNo.Name = "lblCNo";
            this.lblCNo.Size = new System.Drawing.Size(132, 22);
            this.lblCNo.TabIndex = 2;
            this.lblCNo.Text = "Consumer Number";
            // 
            // txtName
            // 
            this.txtName.AutoSize = false;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtName.Location = new System.Drawing.Point(203, 33);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 24);
            this.txtName.TabIndex = 1;
            // 
            // lbname
            // 
            this.lbname.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.Teal;
            this.lbname.Location = new System.Drawing.Point(51, 33);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(46, 22);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Name";
            // 
            // txtMeterNo
            // 
            this.txtMeterNo.AutoSize = false;
            this.txtMeterNo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtMeterNo.Location = new System.Drawing.Point(203, 156);
            this.txtMeterNo.Multiline = true;
            this.txtMeterNo.Name = "txtMeterNo";
            this.txtMeterNo.PasswordChar = '*';
            this.txtMeterNo.Size = new System.Drawing.Size(198, 24);
            this.txtMeterNo.TabIndex = 14;
            // 
            // frmConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.radGb2);
            this.Controls.Add(this.radGb1);
            this.Name = "frmConsumer";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmConsumer";
            ((System.ComponentModel.ISupportInitialize)(this.radGb1)).EndInit();
            this.radGb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGb2)).EndInit();
            this.radGb2.ResumeLayout(false);
            this.radGb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsumerNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlbActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMeterNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGb1;
        private Telerik.WinControls.UI.RadGridView rgvUsers;
        private Telerik.WinControls.UI.RadGroupBox radGb2;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtConsumerNo;
        private Telerik.WinControls.UI.RadTextBox txtType;
        private Telerik.WinControls.UI.RadButton btnNew;
        private Telerik.WinControls.UI.RadDropDownList ddlActive;
        private Telerik.WinControls.UI.RadLabel lblMeter;
        private Telerik.WinControls.UI.RadLabel rlbActive;
        private Telerik.WinControls.UI.RadLabel lbType;
        private Telerik.WinControls.UI.RadLabel lblCNo;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadLabel lbname;
        private Telerik.WinControls.UI.RadTextBox txtMeterNo;
    }
}
