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
    public partial class Content : UserControl
    {
        public Content()
        {
            InitializeComponent();
        }

        public delegate void uddProfileSelected();
        public event uddProfileSelected udeProfileSelected;


        public string  udpProfileName
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmInputText f = new frmInputText(clsLang.udfGetRes(clsLang.enLangRes.inp_ContentProfile));
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtBody.Text="";
                int? nid = tblContentTableAdapter.ScalarNID();
                ds.tblContentRow nr;

                if (!nid.HasValue) { nid = 1; }

                nr = ds.tblContent.NewtblContentRow();

                nr.ID = nid.Value;
                nr.ProfileName = f.udpValue;
                nr.Body = "";
                nr.isHtml = false;

                ds.tblContent.Rows.Add(nr);

                tblContentTableAdapter.Update(ds.tblContent);
                tblContentBindingSource.MoveLast();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbProfile.SelectedValue != null)
            {
                if (MessageBox.Show(string.Format("Do you want to delete {0} ?" , cmbProfile.Text), "Content Profile Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new dsTableAdapters.tblSendLogTableAdapter().DeleteContentID(Convert.ToInt32( cmbProfile.SelectedValue));
                    tblContentBindingSource.EndEdit();
                    tblContentBindingSource.RemoveCurrent();
                    tblContentTableAdapter.Update(ds.tblContent);                    
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbProfile.SelectedValue != null)
            {
                frmInputText ed = new frmInputText(clsLang.udfGetRes(clsLang.enLangRes.inp_ContentProfile));

                ed.udpValue = cmbProfile.Text;
                if (ed.ShowDialog() == DialogResult.OK)
                {
                    ds.tblContentRow er = ds.tblContent.Where(z => z.ID == Convert.ToInt32(cmbProfile.SelectedValue)).Single();
                    er.ProfileName = ed.udpValue;
                    tblContentTableAdapter.Update(ds.tblContent);
                }
            }  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbProfile.SelectedValue != null)
            {
                tblContentBindingSource.EndEdit();
                
                tblContentTableAdapter.Update (ds.tblContent);
            }
        }

        public void udfBindData()
        {
            tblContentTableAdapter.Fill(ds.tblContent);
            if (udeProfileSelected != null) { udeProfileSelected(); }
        }

        private void cmbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (udeProfileSelected != null)
            {
                udeProfileSelected();
            }
        }

        public void udfRefreshInterface()
        {
            lbContent.Text = clsLang.udfGetRes(clsLang.enLangRes.Content);            
            lbProfile.Text = clsLang.udfGetRes(clsLang.enLangRes.Profile);
            lbSubject.Text = clsLang.udfGetRes(clsLang.enLangRes.Subject);
            txtBody.Tag = clsLang.udfGetRes(clsLang.enLangRes.txt_ContentBody);
            txtSubject.Tag = clsLang.udfGetRes(clsLang.enLangRes.txt_subject);                       
            chkIsHtml.Text = clsLang.udfGetRes(clsLang.enLangRes.chk_isHtml);

            iToolTip.SetToolTip(btnNew, clsLang.udfGetRes(clsLang.enLangRes.tip_add));
            iToolTip.SetToolTip(btnEdit, clsLang.udfGetRes(clsLang.enLangRes.tip_edit));
            iToolTip.SetToolTip(btnDelete,clsLang.udfGetRes(clsLang.enLangRes.tip_delete));
            iToolTip.SetToolTip(btnSave, clsLang.udfGetRes(clsLang.enLangRes.tip_Save));

            switch (clsLang.udpLanguage.ToUpper())
            {
                case "FARSI":
                    txtHelp.Text = Properties.Resources.CONTENT_PERSIAN;
                    txtHelp.RightToLeft = RightToLeft.Yes;
                    break;
                case "ENGLISH":
                    txtHelp.Text = Properties.Resources.CONTENT_ENGLISH;
                    txtHelp.RightToLeft = RightToLeft.No;
                    break;
                default:                    
                    txtHelp.Text = Properties.Resources.CONTENT_ENGLISH;
                    txtHelp.RightToLeft = RightToLeft.No;
                    break;
            }
        }

        
    }
}
