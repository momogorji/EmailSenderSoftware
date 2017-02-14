using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MMG_Soft_MailSender.Class;

namespace MMG_Soft_MailSender.UserCtrl
{
    public partial class SenderProfile : UserControl
    {
        public SenderProfile()
        {
            InitializeComponent();

            cmbPriority.udfLoad();
        }

        public delegate void uddProfileSelected();
        public event uddProfileSelected udeProfileSelected;

        public int udpProfileId
        {
            get
            {
                if (cmbProfile.SelectedValue != null)
                {
                    return Convert.ToInt32(cmbProfile.SelectedValue);
                }
                else
                {
                    return -1;
                }
            }
        }


        public string udpProfileName
        {
            get
            {
                if (cmbProfile.SelectedValue != null)
                {
                    return cmbProfile.Text;
                }
                else
                {
                    return "";
                }
            }
        }

        private bool m_validate = false;
        private bool m_NewItemSave = false;

        public void udfBindData()
        {
            tblSenderTableAdapter.Fill(ds.tblSender);
            if (udeProfileSelected != null) { udeProfileSelected(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m_validate = true;
            if (ValidateChildren())
            {
                m_NewItemSave = false;
                tblSenderBindingSource.EndEdit();
                tblSenderTableAdapter.Update(ds.tblSender);
                ds.tblSender.AcceptChanges();
            }
            m_validate = false;
        }




        private void btnNew_Click(object sender, EventArgs e)
        {
            frmInputText inp = new frmInputText(clsLang.udfGetRes(clsLang.enLangRes.Profile));

            if (inp.ShowDialog() == DialogResult.OK)
            {
                ds.tblSenderRow nr;
                nr = ds.tblSender.NewtblSenderRow();

                if (ds.tblSender.Count > 0)
                {
                    nr.ID = (ds.tblSender.Max(z => z.ID) + 1);
                }
                else
                {
                    nr.ID = 1;
                }
                nr.ProfileName = inp.udpValue;
                nr.FromAddress = "";
                nr.DisplayName = "";
                nr.ReplayTo = "";
                nr.DeliveryNotification = false;
                nr.Priority = 0;
                nr.CustomHeader = "";
                nr.SMTP_Server = "";
                nr.ServerPort = 25;
                nr.UserName = "";
                nr.Password = "";
                nr.SleepInterval = 30;

                ds.tblSender.Rows.Add(nr);
                m_NewItemSave = true;
                tblSenderBindingSource.MoveLast();
            }
        }

        private void tblSenderBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (!m_NewItemSave) { ds.tblSender.RejectChanges(); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbProfile.SelectedValue != null)
            {
                frmInputText ed = new frmInputText(clsLang.udfGetRes(clsLang.enLangRes.Profile));

                ed.udpValue = cmbProfile.Text;
                if (ed.ShowDialog() == DialogResult.OK)
                {
                    ds.tblSenderRow er = ds.tblSender.Where(z => z.ID == Convert.ToInt32(cmbProfile.SelectedValue)).Single();
                    er.ProfileName = ed.udpValue;
                }
            }
        }

        private void udfValidated(object sender, EventArgs e)
        {
            iErr.SetError((Control)sender, "");
        }

        private void txtFrom_Validating(object sender, CancelEventArgs e)
        {
            if (!m_validate) { return; }

            string reg = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                         + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                         + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                         + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

            if (!Regex.IsMatch(txtFrom.Text, reg))
            {
                e.Cancel = true;
                iErr.SetError((Control)sender, clsLang.udfGetRes(clsLang.enLangRes.str_invalid_email));
            }

        }

        private void txtServer_Validating(object sender, CancelEventArgs e)
        {
            if (!m_validate) { return; }
            if (txtServer.Text == "")
            {
                e.Cancel = true;
                iErr.SetError((Control)sender, clsLang.udfGetRes(clsLang.enLangRes.str_enter_smtp_server));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbProfile.SelectedValue != null)
            {
                if (MessageBox.Show(string.Format(clsLang.udfGetRes(clsLang.enLangRes.dia_Delete) + " {0}", cmbProfile.Text), "Delete Sender Profile", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tblSenderBindingSource.EndEdit();
                    tblSenderBindingSource.RemoveCurrent();
                    tblSenderTableAdapter.Update(ds.tblSender);
                }
            }
        }

        private void cmbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfile.SelectedValue != null)
            {
                if (udeProfileSelected != null)
                {
                    udeProfileSelected();
                }
            }
        }

        public void udfRefreshInterface()
        {

            lbSender.Text = clsLang.udfGetRes(clsLang.enLangRes.Sender);
            lbFrom.Text = clsLang.udfGetRes(clsLang.enLangRes.FromAddress_text);
            lbDisplay.Text = clsLang.udfGetRes(clsLang.enLangRes.Displayname_text);
            lbReplay.Text = clsLang.udfGetRes(clsLang.enLangRes.Replayto_text);
            lbPriority.Text = clsLang.udfGetRes(clsLang.enLangRes.Priority_text);
            chkDelivery.Text = clsLang.udfGetRes(clsLang.enLangRes.Delivery_text);
            chkUseSSL.Text = clsLang.udfGetRes(clsLang.enLangRes.SSL_text);
            lbSMTP.Text = clsLang.udfGetRes(clsLang.enLangRes.Server_Text);
            lbUser.Text = clsLang.udfGetRes(clsLang.enLangRes.User_text);
            lbPw.Text = clsLang.udfGetRes(clsLang.enLangRes.Password_text);
            lbPort.Text = clsLang.udfGetRes(clsLang.enLangRes.Port_text);
            lbSleep.Text = clsLang.udfGetRes(clsLang.enLangRes.Sleep_text);
            lbSleepunit.Text = clsLang.udfGetRes(clsLang.enLangRes.Sleep_Unit);
            lbProfile.Text = clsLang.udfGetRes(clsLang.enLangRes.Profile);

            iToolTip.SetToolTip(btnNew, clsLang.udfGetRes(clsLang.enLangRes.tip_add));
            iToolTip.SetToolTip(btnEdit, clsLang.udfGetRes(clsLang.enLangRes.tip_edit));
            iToolTip.SetToolTip(btnDelete, clsLang.udfGetRes(clsLang.enLangRes.tip_delete));
            iToolTip.SetToolTip(btnSave, clsLang.udfGetRes(clsLang.enLangRes.tip_Save));


            switch (clsLang.udpLanguage.ToUpper())
            {
                case "FARSI":
                    txtHelp.Text = Properties.Resources.SENDER_PERSIAN;
                    txtHelp.RightToLeft = RightToLeft.Yes;
                    break;
                case "ENGLISH":
                    txtHelp.Text = Properties.Resources.SENDER_ENGLISH;
                    txtHelp.RightToLeft = RightToLeft.No;
                    break;
                default:
                    txtHelp.Text = Properties.Resources.SENDER_ENGLISH;
                    txtHelp.RightToLeft = RightToLeft.No;
                    break;                    
            }
        }
    }
}