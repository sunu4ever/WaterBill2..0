using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Waterbill2.UI
{
    public partial class frmHome : frmBaseRadForm
    {
        #region
        public frmHome()
        {
            InitializeComponent();
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            InitilizeHome();
        }
        private void radHomePageView_PageRemoving(object sender, RadPageViewCancelEventArgs e)
        {
            if (e.Page.TabIndex == 0)
                e.Cancel = true;
        }
        #endregion

        #region Methods
        private void InitilizeHome()
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height - 40;
            this.Location = new Point();
            this.StartPosition = FormStartPosition.Manual;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

            this.radHomePageView.Left = 0;
            this.radHomePageView.Top = 0;
            this.radHomePageView.Width = Screen.PrimaryScreen.Bounds.Width;
            this.radHomePageView.Height = Screen.PrimaryScreen.Bounds.Height - 78;

            RadPageViewPage page = new RadPageViewPage();
            page.Text = "Home";

            frmHomeTab homePage;
            homePage = new frmHomeTab();
            homePage.TopLevel = false;
            homePage.Dock = DockStyle.Fill;
            homePage.FormBorderStyle = FormBorderStyle.None;

            page.Controls.Add(homePage);
            this.radHomePageView.Pages.Add(page);
            homePage.Show();
        }

        #endregion

       

    }
}
