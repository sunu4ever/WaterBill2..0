namespace Waterbill2.UI
{
    partial class frmBills
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnGenerateBill = new Telerik.WinControls.UI.RadButton();
            this.dpTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.drpYear = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.drpMonth = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.rgvSaleDetails = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerateBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgvSaleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.btnGenerateBill);
            this.radGroupBox1.Controls.Add(this.dpTo);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.drpYear);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.drpMonth);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Generate Bill";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(316, 391);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Generate Bill";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnGenerateBill.Location = new System.Drawing.Point(78, 290);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(144, 37);
            this.btnGenerateBill.TabIndex = 87;
            this.btnGenerateBill.Text = "Generate Bill";
            // 
            // dpTo
            // 
            this.dpTo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.dpTo.Location = new System.Drawing.Point(42, 238);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(221, 24);
            this.dpTo.TabIndex = 86;
            this.dpTo.TabStop = false;
            this.dpTo.Text = "Saturday, December 06, 2014";
            this.dpTo.Value = new System.DateTime(2014, 12, 6, 0, 0, 0, 0);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radLabel3.ForeColor = System.Drawing.Color.Teal;
            this.radLabel3.Location = new System.Drawing.Point(104, 197);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(68, 22);
            this.radLabel3.TabIndex = 22;
            this.radLabel3.Text = "Due Date";
            // 
            // drpYear
            // 
            this.drpYear.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.drpYear.Location = new System.Drawing.Point(42, 72);
            this.drpYear.Name = "drpYear";
            this.drpYear.Size = new System.Drawing.Size(221, 24);
            this.drpYear.TabIndex = 21;
            this.drpYear.Text = "Please Select Year";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radLabel2.ForeColor = System.Drawing.Color.Teal;
            this.radLabel2.Location = new System.Drawing.Point(101, 31);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 22);
            this.radLabel2.TabIndex = 20;
            this.radLabel2.Text = "Select Year";
            // 
            // drpMonth
            // 
            this.drpMonth.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.drpMonth.Location = new System.Drawing.Point(42, 154);
            this.drpMonth.Name = "drpMonth";
            this.drpMonth.Size = new System.Drawing.Size(221, 24);
            this.drpMonth.TabIndex = 19;
            this.drpMonth.Text = "Please Select Month";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.ForeColor = System.Drawing.Color.Teal;
            this.radLabel1.Location = new System.Drawing.Point(93, 111);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(95, 22);
            this.radLabel1.TabIndex = 15;
            this.radLabel1.Text = "Select Month";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.rgvSaleDetails);
            this.radGroupBox2.HeaderText = "Bill List";
            this.radGroupBox2.Location = new System.Drawing.Point(336, 12);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(910, 391);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Bill List";
            // 
            // rgvSaleDetails
            // 
            this.rgvSaleDetails.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgvSaleDetails.Location = new System.Drawing.Point(11, 29);
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
            gridViewTextBoxColumn1.FieldName = "Sl.No";
            gridViewTextBoxColumn1.HeaderText = "Sl.No#";
            gridViewTextBoxColumn1.MinWidth = 20;
            gridViewTextBoxColumn1.Name = "Sl.No";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 70;
            gridViewTextBoxColumn1.WrapText = true;
            gridViewTextBoxColumn2.HeaderText = "Bill Master Id";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn3.HeaderText = "Year";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.HeaderText = "Month";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.HeaderText = "Bill Generated Date";
            gridViewTextBoxColumn5.Name = "column7";
            gridViewTextBoxColumn5.Width = 150;
            gridViewTextBoxColumn6.HeaderText = "Total Consumer";
            gridViewTextBoxColumn6.Name = "column6";
            gridViewTextBoxColumn6.Width = 120;
            gridViewTextBoxColumn7.HeaderText = "Due Date";
            gridViewTextBoxColumn7.Name = "column4";
            gridViewTextBoxColumn7.Width = 150;
            gridViewTextBoxColumn8.HeaderText = "Status";
            gridViewTextBoxColumn8.Name = "column5";
            gridViewTextBoxColumn8.Width = 150;
            this.rgvSaleDetails.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.rgvSaleDetails.MasterTemplate.EnableGrouping = false;
            this.rgvSaleDetails.MasterTemplate.EnableSorting = false;
            this.rgvSaleDetails.MasterTemplate.ShowFilteringRow = false;
            this.rgvSaleDetails.MasterTemplate.ShowHeaderCellButtons = true;
            this.rgvSaleDetails.MasterTemplate.ShowRowHeaderColumn = false;
            this.rgvSaleDetails.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvSaleDetails.Name = "rgvSaleDetails";
            this.rgvSaleDetails.ShowGroupPanel = false;
            this.rgvSaleDetails.ShowHeaderCellButtons = true;
            this.rgvSaleDetails.Size = new System.Drawing.Size(887, 350);
            this.rgvSaleDetails.TabIndex = 59;
            this.rgvSaleDetails.Text = "radGridView1";
            this.rgvSaleDetails.UseCompatibleTextRendering = false;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(93, 355);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 88;
            this.radButton1.Text = "radButton1";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // frmBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 417);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBills";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Bills";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerateBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drpMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgvSaleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnGenerateBill;
        private Telerik.WinControls.UI.RadDateTimePicker dpTo;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList drpYear;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList drpMonth;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView rgvSaleDetails;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
