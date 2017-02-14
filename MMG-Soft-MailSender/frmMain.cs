using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using DevComponents.DotNetBar;
using MMG_Soft_MailSender.Class;

namespace MMG_Soft_MailSender
{
    public partial class frmMain : Office2007Form
    {
        public frmMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        private MailMessage mail = new MailMessage();
        private int m_page = 1;

        private void Form1_Load(object sender, EventArgs e)
        {


            

            frmSplash spl = new frmSplash();
            
            Visible = false;
            Properties.Settings.Default["MMG_MailConnectionString"] = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ Application.StartupPath  +@"\Db\MMG-Mail.mdb";

            usSenderProfile.udfBindData();
            usRecipients.udfBindData();
            usContent.udfBindData();
            

            usAbout.udfRefreshInterface();
            usContent.udfRefreshInterface();
            usRecipients.udfRefreshInterface();
            usSenderProfile.udfRefreshInterface();
            usMailSender.udfRefreshInterface();
            uslicence.udfRefreshInterface();
            uslicence.Visible = false;
            udfRefreshInterface();

            spl.ShowDialog();

            if (!this.IsDisposed)
            {
                Visible = true;
            }

        }

        private void btnSenderProfile_Click(object sender, EventArgs e)
        {
            m_page = 1;
            btnPrev.Visible = true;
            btnNext.Visible = true;
            btnPrev.Enabled = false;
            btnNext.Enabled = true;
            usSenderProfile.Visible = true ;
            usRecipients.Visible = false;
            usMailSender.Visible = false;
            usContent.Visible = false;
            uslicence.Visible = false;
            usAbout.Visible = false;
            usProduct.Visible = false;

            btnAbout.Checked = false;
            btnContent.Checked = false;
            btnProduct.Checked = false;
            btnRecipients.Checked = false;
            btnSenderProfile.Checked = true ;
            btnSendMail.Checked = false;
            btnlicence.Checked = false;
        }

        private void btnRecipients_Click(object sender, EventArgs e)
        {
            m_page = 2;
            btnPrev.Visible = true;
            btnNext.Visible = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            usRecipients.udfRefreshItems();
            uslicence.Visible = false;
            usSenderProfile.Visible = false;
            usRecipients.Visible = true ;
            usMailSender.Visible = false;
            usContent.Visible = false;
            usAbout.Visible = false;
            usProduct.Visible = false;

            btnAbout.Checked = false;
            btnContent.Checked = false;
            btnProduct.Checked = false;
            btnRecipients.Checked = true ;
            btnSenderProfile.Checked = false;
            btnSendMail.Checked = false;
            btnlicence.Checked = false;
        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            m_page = 3;
            btnPrev.Visible = true;
            btnNext.Visible = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            usSenderProfile.Visible = false;
            usRecipients.Visible = false;
            usMailSender.Visible = false;
            usContent.Visible = true ;
            uslicence.Visible = false;
            usAbout.Visible = false;
            usProduct.Visible = false;

            btnAbout.Checked = false;
            btnContent.Checked = true ;
            btnProduct.Checked = false;
            btnRecipients.Checked = false;
            btnSenderProfile.Checked = false;
            btnSendMail.Checked = false;
            btnlicence.Checked = false;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            m_page = 4;
            btnPrev.Visible = true;
            btnNext.Visible = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = false;
            usSenderProfile.Visible = false;
            usRecipients.Visible = false;
            usMailSender.Visible = true ;
            usContent.Visible = false;
            uslicence.Visible = false;
            usAbout.Visible = false;
            usProduct.Visible = false;

            usMailSender.udfSetInfo(usSenderProfile.udpProfileName, usRecipients.udpProfileName, usContent.udpProfileName);

            btnAbout.Checked = false;
            btnContent.Checked = false;
            btnProduct.Checked = false;
            btnRecipients.Checked = false;
            btnSenderProfile.Checked = false;
            btnSendMail.Checked = true ;
            btnlicence.Checked = false;
        }

        private void usMailSender_udeStartSend()
        {
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
            sideBar1.Enabled = false;
            usMailSender.udpContentProfileID = usContent.udpProfileId;
            usMailSender.udpRecipientsProfileId = usRecipients.udpProfileId;
            usMailSender.udpSenderProfileID = usSenderProfile.udpProfileId;
        }

        private void usContent_udeProfileSelected()
        {
            usRecipients.udpContentID = usContent.udpProfileId;
        }

        private void usSenderProfile_udeProfileSelected()
        {
            usRecipients.udpSenderID = usSenderProfile.udpProfileId;
        }

        private void usMailSender_udeSendComplate()
        {
            sideBar1.Enabled = true;            
            btnPrev.Enabled = true ;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (m_page)
            {
                case 1:
                    btnRecipients_Click(null, null);
                    break;
                case 2:
                    btnContent_Click(null, null);
                    break;
                case 3:
                    btnSendMail_Click(null, null);
                    break;                
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            switch (m_page)
            {                
                case 2:
                    btnSenderProfile_Click(null, null);
                    break;
                case 3:
                    btnRecipients_Click(null, null);
                    break;
                case 4:
                    btnContent_Click(null, null);
                    break;

            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            btnPrev.Visible = false ;
            btnNext.Visible = false ;            
            usSenderProfile.Visible = false;
            usRecipients.Visible = false;
            usMailSender.Visible = false;
            usContent.Visible = false;
            usAbout.Visible = true;
            usProduct.Visible = false;
            uslicence.Visible = false;

            btnAbout.Checked = true ;
            btnContent.Checked = false;
            btnProduct.Checked = false;
            btnRecipients.Checked = false;
            btnSenderProfile.Checked = false;
            btnSendMail.Checked = false;
            btnlicence.Checked = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            btnPrev.Visible = false ;
            btnNext.Visible = false ;
            usSenderProfile.Visible = false;
            usRecipients.Visible = false;
            usMailSender.Visible = false;
            usContent.Visible = false;
            uslicence.Visible = false;
            usAbout.Visible = false ;
            usProduct.Visible = true ;
            usProduct.udfLoadSite();


            btnAbout.Checked = false;
            btnContent.Checked = false;
            btnProduct.Checked = true ;
            btnRecipients.Checked = false;
            btnSenderProfile.Checked = false;
            btnSendMail.Checked = false;
            btnlicence.Checked = false;
        }

        private void btnLanguageOption_Click(object sender, EventArgs e)
        {
            new frmLanguageOption().ShowDialog();

            clsLang.udfLoadBaseRes();

            usAbout.udfRefreshInterface();
            usContent.udfRefreshInterface();
            usRecipients.udfRefreshInterface();
            usSenderProfile.udfRefreshInterface();
            usMailSender.udfRefreshInterface();
            uslicence.udfRefreshInterface();
            udfRefreshInterface();
        }

        private void udfRefreshInterface()
        {
            btnAbout.Text = clsLang.udfGetRes(clsLang.enLangRes.mn_about);
            btnSenderProfile.Text = clsLang.udfGetRes(clsLang.enLangRes.mn_sender);
            btnContent.Text = clsLang.udfGetRes(clsLang.enLangRes.mn_content);
            btnSendMail.Text = clsLang.udfGetRes(clsLang.enLangRes.mn_sendmail);
            btnProduct.Text = clsLang.udfGetRes(clsLang.enLangRes.mn_product);
            btnRecipients.Text = clsLang.udfGetRes(clsLang.enLangRes.mn_receipient);
            mnFile.Text = clsLang.udfGetRes(clsLang.enLangRes.mn_file);
            btnExit.Text = clsLang.udfGetRes(clsLang.enLangRes.btn_exit);
            btnLanguageOption.Text = clsLang.udfGetRes(clsLang.enLangRes.bnt_LanguageOption);
            sbpNavigation.Text = clsLang.udfGetRes(clsLang.enLangRes.nav);
            btnlicence.Text = clsLang.udfGetRes(clsLang.enLangRes.mn_licence);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void btnlicence_Click(object sender, EventArgs e)
        {
            frmRegister freg = new frmRegister();
            if (!freg.udfChkRegistration())
            {
                //Visible = false;
                //if (freg.ShowDialog() != DialogResult.OK)
                //{
                //    Application.Exit();
                //}
                Visible = true;
                new frmRegister().ShowDialog();
            }
            else
            {
                btnPrev.Visible = false;
                btnNext.Visible = false;
                usSenderProfile.Visible = false;
                usRecipients.Visible = false;
                usMailSender.Visible = false;
                usContent.Visible = false;
                usAbout.Visible = false;
                usProduct.Visible = false;
                uslicence.Visible = true;
                usProduct.udfLoadSite();


                btnAbout.Checked = false;
                btnContent.Checked = false;
                btnProduct.Checked = false;
                btnRecipients.Checked = false;
                btnSenderProfile.Checked = false;
                btnSendMail.Checked = false;
                btnlicence.Checked = true;


 
            }


        }

     

   

        
    }
}
