using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMG_Soft_MailSender.Class;

namespace MMG_Soft_MailSender
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            lbProductName.Text = clsLang.udfGetRes(clsLang.enLangRes.ProductName);
            lbProductDescription.Text = clsLang.udfGetRes(clsLang.enLangRes.ProductDescription);
            lbVersion.Text = string.Format(clsLang.udfGetRes(clsLang.enLangRes.Vesrion) + "{0}", "1.01");
            lbPublishDate.Text = string.Format(clsLang.udfGetRes(clsLang.enLangRes.PublishDate) + "{0}", "1390");
            lbCompanyTitle.Text = clsLang.udfGetRes(clsLang.enLangRes.CompanyTitle);
            lbCompanyInfo.Text = clsLang.udfGetRes(clsLang.enLangRes.CompanyDescription);
            lbSite.Text = clsLang.udfGetRes(clsLang.enLangRes.CompanySite);
            lbMail.Text = clsLang.udfGetRes(clsLang.enLangRes.ContactEmail);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DialogResult = DialogResult.OK; 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            frmRegister freg = new frmRegister();

            if (!freg.udfChkRegistration())
            {
                //Visible = false;
                //if (freg.ShowDialog() != DialogResult.OK)
                //{
                //    Application.Exit();
                //}
                Visible = true;
            }

            timer1.Enabled = true;
        }
    }
}
