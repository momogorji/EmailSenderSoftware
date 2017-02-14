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
    public partial class frmImportText :   DevComponents.DotNetBar.Office2007Form
    {
        public frmImportText(int RecipientsID)
        {
            InitializeComponent();

            m_RecipientsID = RecipientsID;
        }


        private int m_RecipientsID;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (iOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = iOpenFileDialog.FileName;
                btnOk.Enabled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string emails;
            clsPublic pb = new clsPublic();
            string iem;
            emails = System.IO.File.ReadAllText(txtPath.Text);


            //
            dsTableAdapters.tblRecipientsItemsTableAdapter q = new MMG_Soft_MailSender.dsTableAdapters.tblRecipientsItemsTableAdapter();            
            string spl;
            int? id = q.ScalarNewID();

            if (!id.HasValue)
            {
                id = 1;
            }

            if (chkNewLine.Checked)
            {
                spl = Environment.NewLine;
            }
            else
            {
                spl = txtSplit.Text;
            }

            if (spl.Length == 0)
            {
                MessageBox.Show("Please Enter Split character");
                return;
            }


            foreach (string em in emails.Split(spl.ToCharArray()).Where(z=>z.Length>0))
            {
                Application.DoEvents();

                iem = em.TrimEnd(Environment.NewLine.ToCharArray()).TrimEnd(' ').TrimStart(' ');
                if (!pb.udfEmailValidator(iem)) { continue; }

                if (((Nullable<int>)q.ScalarExist(iem, m_RecipientsID)).Value == 0)
                {
                    q.Insert(id.Value
                        , m_RecipientsID
                        , ""
                        , ""
                        , iem);
                }
                id++;
            }            
            //

            DialogResult = DialogResult.OK;
        }

        private void chkNewLine_CheckedChanged(object sender, EventArgs e)
        {
            txtSplit.Enabled = !chkNewLine.Checked;
        }

        private void frmImportText_Load(object sender, EventArgs e)
        {
            lbFile.Text = clsLang.udfGetRes(clsLang.enLangRes.TextFile);
            lbSplit.Text = clsLang.udfGetRes(clsLang.enLangRes.Split);
            chkNewLine.Text = clsLang.udfGetRes(clsLang.enLangRes.NewLine);
            Text = clsLang.udfGetRes(clsLang.enLangRes.frmTextImport);
        }
    }
}
