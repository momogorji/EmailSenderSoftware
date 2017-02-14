using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMG_Soft_MailSender.Class;

namespace MMG_Soft_MailSender.UserCtrl
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void lbSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(lbLinkSite.Text);
            }
            catch (Exception)
            {

                
            }
        }

        public void udfRefreshInterface()
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
    }
}
