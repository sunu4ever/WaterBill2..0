using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Reflection;

namespace Waterbill2.UI
{
    public partial class frmHomeTab : BaseFormClass
    {
        #region globals
        public bool userClicked = false;
        #endregion 
        #region Evets
        public frmHomeTab()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AddTab("User Details","frmUsers");
        }
        private void btnConsumer_Click(object sender, EventArgs e)
        {
            AddTab("Consumer Details", "frmConsumer");
        }

        private void btnWaterMaster_Click(object sender, EventArgs e)
        {
            AddTab("Water Master", "frmWaterMaster");
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            AddTab("Generate Bill", "frmBills");
        }

        private void btnBillDetails_Click(object sender, EventArgs e)
        {
            AddTab("Bill Details", "frmBillDetails");
        }

        #endregion

        #region Method

      
        #endregion
    }
}
