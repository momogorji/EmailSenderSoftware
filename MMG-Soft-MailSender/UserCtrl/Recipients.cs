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
    public partial class Recipients : UserControl
    {
        public Recipients()
        {
            InitializeComponent();

            
        }

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
        public int udpContentID { get; set; }
        public int udpSenderID { get; set; }

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

        public void udfBindData()
        {
            tblRecipientsTableAdapter.Fill(ds.tblRecipients);
            cmbProfile_SelectedIndexChanged(null, null);
        }

        public void udfRefreshItems()
        {
            cmbProfile_SelectedIndexChanged(null, null);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            new frmExcelImport(Convert.ToInt32( cmbProfile.SelectedValue)).ShowDialog();
            cmbProfile_SelectedIndexChanged(null, null);
        }

        private void cmbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfile.SelectedValue != null)
            {
                btnInsert.Enabled = true;
                btnDelete.Enabled = true;
                btnImport.Enabled = true;
                tblRecipientsItemsTableAdapter.Fill(ds.tblRecipientsItems, Convert.ToInt32(cmbProfile.SelectedValue));
                dsTableAdapters.tblSendLogXTableAdapter q = new MMG_Soft_MailSender.dsTableAdapters.tblSendLogXTableAdapter();
                ds.tblSendLogXDataTable tSercher = new dsTableAdapters.tblSendLogXTableAdapter().GetDataByRCS(Convert.ToInt32(cmbProfile.SelectedValue), udpContentID, udpSenderID);
                ds.tblSendLogXRow xr;

                foreach (DataGridViewRow gr in dtgData.Rows)
                {                    
                    xr = tSercher.Where(z => z.EmailAddress == gr.Cells[clmEmailAddress.Index].Value.ToString()).FirstOrDefault();
                    if (xr == null)
                    {
                        gr.Cells[clmStatus.Index].Value = (int)Class.clsPublic.enStatus.Unsend ;
                    }
                    else
                    {
                        gr.Cells[clmStatus.Index].Value = (int)xr.Status;
           
                    }
                }
            }
            else
            {
                ds.tblRecipientsItems.Clear();
                btnImport.Enabled = false;
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmInputText f = new frmInputText(clsLang.udfGetRes(clsLang.enLangRes.inp_Name_receipient));
            if (f.ShowDialog() == DialogResult.OK)
            {
                int? nid = tblRecipientsTableAdapter.ScalarNid();
                ds.tblRecipientsRow nr;

                if (!nid.HasValue) { nid = 1; }

                nr = ds.tblRecipients.NewtblRecipientsRow();

                nr.ID = nid.Value;
                nr.ProfileName = f.udpValue;

                ds.tblRecipients.Rows.Add(nr);

                tblRecipientsTableAdapter.Update(ds.tblRecipients);
                tblRecipientsBindingSource.MoveLast();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbProfile.SelectedValue != null)
            {
                frmInputText ed = new frmInputText(clsLang.udfGetRes(clsLang.enLangRes.inp_receipients_profile));

                ed.udpValue = cmbProfile.Text;
                if (ed.ShowDialog() == DialogResult.OK)
                {
                    ds.tblRecipientsRow er = ds.tblRecipients.Where(z => z.ID == Convert.ToInt32(cmbProfile.SelectedValue)).Single();
                    er.ProfileName = ed.udpValue;
                    tblRecipientsTableAdapter.Update(ds.tblRecipients);
                }
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cmbProfile.SelectedValue!=null)
            {
                if (MessageBox.Show(string.Format(clsLang.udfGetRes(clsLang.enLangRes.dia_Delete)+" {0} ?"+Environment.NewLine + clsLang.udfGetRes(clsLang.enLangRes.str_AllReceiptsEmailsDelete), cmbProfile.Text), clsLang.udfGetRes(clsLang.enLangRes.str_receipient_delete_caption), MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new dsTableAdapters.tblSendLogTableAdapter().DeleteReceipient(Convert.ToInt32(cmbProfile.SelectedValue));
                    new dsTableAdapters.tblRecipientsItemsTableAdapter().DeleteByMaster(Convert.ToInt32(cmbProfile.SelectedValue));
                    tblRecipientsBindingSource.EndEdit();
                    tblRecipientsBindingSource.RemoveCurrent();
                    tblRecipientsTableAdapter.Update(ds.tblRecipients);
                }
            }
        }

        private void tnMakeUnSend_Click(object sender, EventArgs e)
        {
            dsTableAdapters.tblSendLogTableAdapter q = new MMG_Soft_MailSender.dsTableAdapters.tblSendLogTableAdapter();

            foreach (DataGridViewRow gr in dtgData.SelectedRows)
            {
                if (Convert.ToInt32( gr.Cells[clmStatus.Index].Value) != (int)Class.clsPublic.enStatus.Unsend)
                {
                    q.Delete(Convert.ToInt32(cmbProfile.SelectedValue)
                        , udpContentID
                        , udpSenderID
                        , gr.Cells[clmEmailAddress.Index].Value.ToString());
                }
            }
            cmbProfile_SelectedIndexChanged(null, null);
        }

        private void btnMakeSend_Click(object sender, EventArgs e)
        {
            dsTableAdapters.tblSendLogTableAdapter q = new MMG_Soft_MailSender.dsTableAdapters.tblSendLogTableAdapter();

            foreach (DataGridViewRow gr in dtgData.SelectedRows)
            {                
                if (Convert.ToInt32(gr.Cells[clmStatus.Index].Value) == (int)Class.clsPublic.enStatus.Unsend)
                {
                    q.Insert(Convert.ToInt32(cmbProfile.SelectedValue)
                        , udpContentID
                        , udpSenderID
                        , gr.Cells[clmEmailAddress.Index].Value.ToString()
                        , (byte)Class.clsPublic.enStatus.Send);
                    
                }
                else if (Convert.ToInt32(gr.Cells[clmStatus.Index].Value) == (int)Class.clsPublic.enStatus.Err)
                {
                    q.Update(udpContentID
                        , udpSenderID
                        , gr.Cells[clmEmailAddress.Index].Value.ToString()
                        , (byte)Class.clsPublic.enStatus.Send
                       , Convert.ToInt32(cmbProfile.SelectedValue)); 

                }
            }
            cmbProfile_SelectedIndexChanged(null, null);
        }

        private void btnMarkasBlocked_Click(object sender, EventArgs e)
        {
            dsTableAdapters.tblSendLogTableAdapter q = new MMG_Soft_MailSender.dsTableAdapters.tblSendLogTableAdapter();

            foreach (DataGridViewRow gr in dtgData.SelectedRows)
            {
                if (Convert.ToInt32(gr.Cells[clmStatus.Index].Value) == (int)Class.clsPublic.enStatus.Unsend)
                {
                    q.Insert(Convert.ToInt32(cmbProfile.SelectedValue)                        
                        , udpContentID
                        , udpSenderID
                        , gr.Cells[clmEmailAddress.Index].Value.ToString()
                        , (byte)Class.clsPublic.enStatus.Block);

                }
                else
                {
                    q.Update(udpContentID
                        , udpSenderID
                         , gr.Cells[clmEmailAddress.Index].Value.ToString()
                        , (byte)Class.clsPublic.enStatus.Block
                        , Convert.ToInt32(cmbProfile.SelectedValue));

                }
            }
            cmbProfile_SelectedIndexChanged(null, null);
        }

        private void btnDeleteItems_Click(object sender, EventArgs e)
        {
            if (cmbProfile.SelectedValue == null) { return; }
            if (MessageBox.Show(clsLang.udfGetRes(clsLang.enLangRes.del_emails), clsLang.udfGetRes(clsLang.enLangRes.del_emails_caption), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                dsTableAdapters.tblSendLogTableAdapter q = new MMG_Soft_MailSender.dsTableAdapters.tblSendLogTableAdapter();

                foreach (DataGridViewRow gr in dtgData.SelectedRows)
                {
                    //delete fromn log
                    q.DeleteByEmail_Rece(Convert.ToInt32(cmbProfile.SelectedValue)
                        , gr.Cells[clmEmailAddress.Index].Value.ToString());
                    //delete  receipients item
                    tblRecipientsItemsTableAdapter.Delete(Convert.ToInt32(gr.Cells[clmID.Index].Value));
                }
                cmbProfile_SelectedIndexChanged(null, null);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbProfile.SelectedValue == null) { return; }
            frmInputText inp = new frmInputText(clsLang.udfGetRes( clsLang.enLangRes.inp_email));

            lbTry:
            if (inp.ShowDialog() == DialogResult.OK)
            {
                string reg = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                  + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                  + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                  + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

                if (!Regex.IsMatch(inp.udpValue, reg))
                {
                    MessageBox.Show(clsLang.udfGetRes(clsLang.enLangRes.str_invalid_email));
                    goto lbTry;
                }
                else
                {
                    if (ds.tblRecipientsItems.Where(z => z.EmailAddress == inp.udpValue).Count() == 0)
                    {
                        tblRecipientsItemsTableAdapter.Insert(tblRecipientsItemsTableAdapter.ScalarNewID().Value
                            , Convert.ToInt32(cmbProfile.SelectedValue)
                            , ""
                            , ""
                            , inp.udpValue);
                        cmbProfile_SelectedIndexChanged(null, null);
                    }
                }
            }
        }


        public void udfRefreshInterface()
        {
            
            lbReceipients.Text = clsLang.udfGetRes(clsLang.enLangRes.Receipients);            
            btnImport.Text = clsLang.udfGetRes(clsLang.enLangRes.btn_ImortReceipient_Text);            
            btnTextImport.Text = clsLang.udfGetRes(clsLang.enLangRes.btn_ImortTextReceipient_Text);                                    
            btnMarkAsUnSend.Text = clsLang.udfGetRes(clsLang.enLangRes.btn_MarkUnSend_text);                                  
            btnMarkAsSend.Text = clsLang.udfGetRes(clsLang.enLangRes.btn_MarkSend_text);                                               
            btnMarkasBlocked.Text = clsLang.udfGetRes(clsLang.enLangRes.btn_MarkBock_text);                                  
            clmStatus.HeaderText = clsLang.udfGetRes(clsLang.enLangRes.clm_Status);            
            clmEmailAddress.HeaderText = clsLang.udfGetRes(clsLang.enLangRes.clm_Email);           
            lbProfile.Text = clsLang.udfGetRes(clsLang.enLangRes.Profile);


            iToolTip.SetToolTip(btnNew, clsLang.udfGetRes(clsLang.enLangRes.tip_add));
            iToolTip.SetToolTip(btnEdit, clsLang.udfGetRes(clsLang.enLangRes.tip_edit));
            iToolTip.SetToolTip(btnDelete, clsLang.udfGetRes(clsLang.enLangRes.tip_delete));

            iToolTip.SetToolTip(btnTextImport, clsLang.udfGetRes(clsLang.enLangRes.tip_Imp_Txt));
            iToolTip.SetToolTip(btnImport, clsLang.udfGetRes(clsLang.enLangRes.tip_Imp_Exc));
            iToolTip.SetToolTip(btnMarkasBlocked, clsLang.udfGetRes(clsLang.enLangRes.tip_Block));
            iToolTip.SetToolTip(btnMarkAsSend, clsLang.udfGetRes(clsLang.enLangRes.tip_Send));
            iToolTip.SetToolTip(btnMarkAsUnSend, clsLang.udfGetRes(clsLang.enLangRes.tip_UnSend));

            iToolTip.SetToolTip(btnInsert, clsLang.udfGetRes(clsLang.enLangRes.tip_Add_email));
            iToolTip.SetToolTip(btnDeleteItems, clsLang.udfGetRes(clsLang.enLangRes.tip_delete_email));


            switch (clsLang.udpLanguage.ToUpper())
            {
                case "FARSI":
                    txtHelp.Text = Properties.Resources.RECEIPIENTS_PERSIAN;
                    txtHelp.RightToLeft = RightToLeft.Yes;
                    break;
                case "ENGLISH":
                    txtHelp.Text = Properties.Resources.RECEIPIENTS_ENGLISH;
                    txtHelp.RightToLeft = RightToLeft.No;
                    break;
                default:                    
                    txtHelp.Text = Properties.Resources.RECEIPIENTS_ENGLISH;
                    txtHelp.RightToLeft = RightToLeft.No;
                    break;
            }
        }

 
        


   

   

        private void btnTextImport_Click(object sender, EventArgs e)
        {
            new frmImportText(Convert.ToInt32(cmbProfile.SelectedValue)).ShowDialog();
            cmbProfile_SelectedIndexChanged(null, null);
        }
        
    }
}
