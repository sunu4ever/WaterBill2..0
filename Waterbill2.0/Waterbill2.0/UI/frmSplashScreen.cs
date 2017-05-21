using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Waterbill2.UI
{
    public partial class frmSplashScreen : frmBaseRadForm
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
