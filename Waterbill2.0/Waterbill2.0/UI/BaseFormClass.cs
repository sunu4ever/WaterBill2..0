using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Reflection;
using System.Drawing;

namespace Waterbill2.UI
{
    public class BaseFormClass : Telerik.WinControls.UI.RadForm
    {
        #region globals
        public bool userClicked = false;
        #endregion
        public BaseFormClass()
        {
            this.FormClosed += new FormClosedEventHandler((sender, e) => form_FormClosed(sender, e));
        }
        public void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            var pageView = (RadPageView)this.Parent.Parent;
            pageView.Pages.RemoveAt(pageView.SelectedPage.TabIndex);
        }
        public void AddTab(string formTitle, string formName)
        {
            RadPageViewPage page = new RadPageViewPage();
            page.BackColor = ColorTranslator.FromHtml("#8DD7D7");
            page.ForeColor = ColorTranslator.FromHtml("#8DD7D7");

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
                    if (type.BaseType == typeof(BaseFormClass) || type.BaseType == typeof(Form) || type.BaseType == typeof(RadForm))
                    {
                        if (type.Name == formName)
                        {
                            frmShow = (Form)frmAssembly.CreateInstance(type.ToString());

                        }
                    }
                }
                if (frmShow == null) return;


                //RadPageViewPage page = new RadPageViewPage();
                //frmShow.FormBorderStyle = FormBorderStyle.None;
                int Width = Screen.PrimaryScreen.Bounds.Width;
                int Height = Screen.PrimaryScreen.Bounds.Height - 150;
                int frmWidth = frmShow.Width;
                int leftPos = (Width - frmWidth) / 2;
                int frmHeight = frmShow.Height;
                int topPos = (Height - frmHeight) / 2;

                frmShow.TopLevel = false;
                frmShow.Top = topPos;
                frmShow.Left = leftPos;
                page.Text = formTitle;
                //  page.BackColor = System.Drawing.Color.White;
                // page.ForeColor = System.Drawing.Color.White;
                //frmShow.BringToFront();

                frmShow.Show();
                page.Controls.Add(frmShow);

                //var pageView = (RadPageView)this.Parent.Parent;
                frmShow.Show();
                //frmShow.BringToFront();
                frmShow.StartPosition = FormStartPosition.CenterScreen;

                //frmShow.FormBorderStyle = FormBorderStyle.None;
                // page.Show();

                //pageView.Pages.Add(page);
                userClicked = false;
            }
        }
    }
}
