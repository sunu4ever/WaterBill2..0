using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Collections;

namespace Waterbill2.UI
{
    public partial class frmUsers : Telerik.WinControls.UI.RadForm
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void ClearField()
        {
            txtFirstName.Text = "";
            txtLoginId.Text = "";
            txtPassword.Text = "";
           // lblUserId.Text = "";
            txtPassword.Enabled = true;
            txtPassword.Text = "";
            ddlActive.SelectedIndex = 0;
            ddlRoles.SelectedIndex = 0;
            //buttonUnregularChangePassword.Enabled = false;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ArrayList Param = new ArrayList();

            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter the first name", "WatwrBill");
                return;
            }
            if (txtLoginId.Text == "")
            {
                MessageBox.Show("Please enter the login name", "WatwrBill");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter the Password", "WatwrBill");
                return;
            }
            if (ddlRoles.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a Role", "WatwrBill");
                return;
            }
            if (ddlActive.SelectedIndex == 0)
            {
                MessageBox.Show("Please select active Yes/No", "WatwrBill");
                return;
            }

           /* if (lblUserId.Text == "")
            {
                if (WBLib.User.CheckUserNameExists(txtLoginId.Text.ToString()) == true)
                {
                    MessageBox.Show("Login ID Already Exists!!! Plese Choose a Different Login ID", "WatwrBill");
                    return;
                }
                Param.Add(0);
            }
            else
            {
                Param.Add(Convert.ToInt32(lblUserId.Text.ToString()));
            }
            Param.Add(txtFirstName.Text.ToString());
            Param.Add(txtLoginId.Text.ToString());
            Param.Add(txtPassword.Text.ToString());
            Param.Add(Convert.ToInt32(ddlRoles.SelectedValue.ToString()));
            Param.Add(Convert.ToInt32(ddlActive.SelectedValue.ToString()));*/
            //if (WBLib.User.SaveUser(Param) == true)
            //{
            //    MessageBox.Show("Saved Succsessfully", "WaterBill");
            //    ClearField();
            //   // FillUsers();
            //}
            //else
            //{
            //    MessageBox.Show("Error in Saving", "WaterBill");
            //}
        }
    }
}
