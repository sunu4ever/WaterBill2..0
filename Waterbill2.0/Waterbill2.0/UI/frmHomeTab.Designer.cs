namespace Waterbill2.UI
{
    partial class frmHomeTab
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
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.btnUser = new Telerik.WinControls.UI.RadButton();
            this.btnConsumer = new Telerik.WinControls.UI.RadButton();
            this.btnWaterMaster = new Telerik.WinControls.UI.RadButton();
            this.btnBillDetails = new Telerik.WinControls.UI.RadButton();
            this.btnGenerateBill = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWaterMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBillDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerateBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUser.Location = new System.Drawing.Point(48, 44);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(127, 40);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnConsumer
            // 
            this.btnConsumer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConsumer.Location = new System.Drawing.Point(210, 44);
            this.btnConsumer.Name = "btnConsumer";
            this.btnConsumer.Size = new System.Drawing.Size(127, 40);
            this.btnConsumer.TabIndex = 2;
            this.btnConsumer.Text = "Consumer";
            this.btnConsumer.Click += new System.EventHandler(this.btnConsumer_Click);
            // 
            // btnWaterMaster
            // 
            this.btnWaterMaster.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnWaterMaster.Location = new System.Drawing.Point(386, 44);
            this.btnWaterMaster.Name = "btnWaterMaster";
            this.btnWaterMaster.Size = new System.Drawing.Size(127, 40);
            this.btnWaterMaster.TabIndex = 3;
            this.btnWaterMaster.Text = "Water Master";
            this.btnWaterMaster.Click += new System.EventHandler(this.btnWaterMaster_Click);
            // 
            // btnBillDetails
            // 
            this.btnBillDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBillDetails.Location = new System.Drawing.Point(718, 44);
            this.btnBillDetails.Name = "btnBillDetails";
            this.btnBillDetails.Size = new System.Drawing.Size(127, 40);
            this.btnBillDetails.TabIndex = 4;
            this.btnBillDetails.Text = "Bill Details";
            this.btnBillDetails.Click += new System.EventHandler(this.btnBillDetails_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerateBill.Location = new System.Drawing.Point(555, 44);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(127, 40);
            this.btnGenerateBill.TabIndex = 5;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // frmHomeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1007, 377);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.btnBillDetails);
            this.Controls.Add(this.btnWaterMaster);
            this.Controls.Add(this.btnConsumer);
            this.Controls.Add(this.btnUser);
            this.Name = "frmHomeTab";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmHomeTab";
            this.ThemeName = "Office2010Blue";
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWaterMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBillDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerateBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.RadButton btnUser;
        private Telerik.WinControls.UI.RadButton btnConsumer;
        private Telerik.WinControls.UI.RadButton btnWaterMaster;
        private Telerik.WinControls.UI.RadButton btnBillDetails;
        private Telerik.WinControls.UI.RadButton btnGenerateBill;
    }
}
