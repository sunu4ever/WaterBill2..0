namespace Waterbill2.UI
{
    partial class frmHome
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
            this.radHomePageView = new Telerik.WinControls.UI.RadPageView();
            ((System.ComponentModel.ISupportInitialize)(this.radHomePageView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radHomePageView
            // 
            this.radHomePageView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(212)))), ((int)(((byte)(251)))));
            this.radHomePageView.Cursor = System.Windows.Forms.Cursors.Default;
            this.radHomePageView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radHomePageView.Location = new System.Drawing.Point(12, 19);
            this.radHomePageView.Name = "radHomePageView";
            this.radHomePageView.Size = new System.Drawing.Size(1174, 383);
            this.radHomePageView.TabIndex = 1;
            this.radHomePageView.Text = "radPageView1";
            this.radHomePageView.PageRemoving += new System.EventHandler<Telerik.WinControls.UI.RadPageViewCancelEventArgs>(this.radHomePageView_PageRemoving);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radHomePageView.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radHomePageView.GetChildAt(0))).ShowItemCloseButton = true;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radHomePageView.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(212)))), ((int)(((byte)(251)))));
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radHomePageView.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.StripViewItemLayout)(this.radHomePageView.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 421);
            this.Controls.Add(this.radHomePageView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radHomePageView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.RadPageView radHomePageView;
    }
}
