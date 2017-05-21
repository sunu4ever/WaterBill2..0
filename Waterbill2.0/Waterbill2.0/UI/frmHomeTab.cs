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
    public partial class frmHomeTab : frmBaseRadForm
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

        #endregion

        #region Method

        private void AddTab(string formTitle,string formName)
        {
            RadPageViewPage page = new RadPageViewPage();
            //page.BackColor = System.Drawing.Color.White;
            //page.ForeColor = System.Drawing.Color.White;

            var pageView = (RadPageView)this.Parent.Parent;
            pageView.Pages.Add(page);
            pageView.SelectedPage = page;
            page.Text = formTitle;

            page.Paint += new System.Windows.Forms.PaintEventHandler((sender1, e1) => onPageViewLoad(sender1, e1, formName, formTitle, page, pageView));
            //page.Paint -= new System.Windows.Forms.PaintEventHandler((sender1, e1) => onPageViewLoad(sender1, e1, formName, formTitle, page, pageView));
            userClicked = true;
        }
        private void onPageViewLoad(object sender, System.Windows.Forms.PaintEventArgs e, string formName, string formTitle, RadPageViewPage page, RadPageView pageView)
        {
            if (userClicked)
            {
                Form frmShow = null;
                Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);
                foreach (Type type in frmAssembly.GetTypes())
                {
                    if (type.BaseType == typeof(Form) || type.BaseType == typeof(RadForm))
                    {
                        if (type.Name == formName)
                        {
                            frmShow = (Form)frmAssembly.CreateInstance(type.ToString());

                        }
                    }
                }
                if (frmShow == null) return;


                //RadPageViewPage page = new RadPageViewPage();
                frmShow.FormBorderStyle = FormBorderStyle.None;
                frmShow.TopLevel = false;
                frmShow.Top = 0;
                frmShow.Left = 0;
                page.Text = formTitle;
                //page.BackColor = System.Drawing.Color.White;
                // page.ForeColor = System.Drawing.Color.White;
                page.Controls.Add(frmShow);
                //var pageView = (RadPageView)this.Parent.Parent;
                frmShow.Show();
                frmShow.StartPosition = FormStartPosition.CenterScreen;
                frmShow.FormBorderStyle = FormBorderStyle.None;
                page.Show();

                //pageView.Pages.Add(page);
                userClicked = false;
            }
        }
        #endregion
    }
}
