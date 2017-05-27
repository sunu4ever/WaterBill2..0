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
    public partial class frmBills : BaseFormClass
    {
        public frmBills()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            AddTab("Monthly Bill Details", "frmMonthlyBills");
        }
    }
}
