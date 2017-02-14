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
    public partial class frmExcelImport : DevComponents.DotNetBar.Office2007Form
    {
        public frmExcelImport(int RecipientsId)
        {
            InitializeComponent();

            m_RecipientsID = RecipientsId;
        }

        private int m_RecipientsID;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (iOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = iOpenFileDialog.FileName;
            }
        }

        private void Wizard1_WizardPageChanging(object sender, DevComponents.DotNetBar.WizardCancelPageChangeEventArgs e)
        {
            if (e.OldPage.Name == wpSheet.Name)
            {
                if (lstSheet.SelectedItems.Count == 0)
                {
                    e.Cancel = true;
                }   
            }
            else if (e.OldPage.Name == wpFileSelect.Name)
            {
                try
                {
                    if(!System.IO.File.Exists(txtFile.Text))
                    {
                        e.Cancel = true;
                    }                   
                }
                catch (Exception)
                {
                    e.Cancel = true;                    
                }
            }
         

        }

        private void wpSheet_AfterPageDisplayed(object sender, DevComponents.DotNetBar.WizardPageChangeEventArgs e)
        {
            lstSheet.Items.Clear();
            lstSheet.Items.AddRange(new Class.clsRetrieveExcelSheet().GetExcelSheetNames(txtFile.Text));
            if (lstSheet.Items.Count > 0)
            {
                lstSheet.SelectedIndex = 0;
            }
        }

        private void wpPreviwe_AfterPageDisplayed(object sender, DevComponents.DotNetBar.WizardPageChangeEventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new Class.clsRetrieveExcelSheet().GetExcelSheetData(txtFile.Text, lstSheet.Text);            
        }

        private void Wizard1_FinishButtonClick(object sender, CancelEventArgs e)
        {
            dsTableAdapters.tblRecipientsItemsTableAdapter q = new MMG_Soft_MailSender.dsTableAdapters.tblRecipientsItemsTableAdapter();
            string  em="";
            int ? id=q.ScalarNewID();
            clsPublic pb = new clsPublic();
            if (!id.HasValue)
            {
                id = 1;
            }

            wpFinish.BackButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
            wpFinish.FinishButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
            wpFinish.CancelButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;

            progressBarX1.Maximum = dataGridView1.Rows.Count;
            progressBarX1.Value = 0;
            foreach (DataGridViewRow gr in dataGridView1.Rows.Cast<DataGridViewRow>().Skip(txtImportFromLine.Value-1))
            {
                Application.DoEvents();
                progressBarX1.Value += 1;
                if (txtEmail.Value > 0)
                {
                    em = gr.Cells[txtEmail.Value - 1].Value.ToString();
                }

                if (!pb.udfEmailValidator(em)) { continue; }

                lbstatus.Text = id.Value.ToString() + "/" + progressBarX1.Maximum.ToString();
                if ( ((Nullable<int>)q.ScalarExist(em,m_RecipientsID)).Value == 0)
                {
                    q.Insert(id.Value
                        , m_RecipientsID                        
                        , ""
                        , ""
                        , em);
                }
                id++;

            }

            Close();
        }

        private void frmExcelImport_Load(object sender, EventArgs e)
        {
            wpFileSelect.PageTitle = clsLang.udfGetRes(clsLang.enLangRes.wiz_p1_Tile);
            wpFileSelect.PageDescription = clsLang.udfGetRes(clsLang.enLangRes.wiz_p1_Description);

            lbProfile.Text = clsLang.udfGetRes(clsLang.enLangRes.wiz_p1_SelectFile);
            

            wpSheet.PageTitle = clsLang.udfGetRes(clsLang.enLangRes.wiz_p2_Title);
            wpSheet.PageDescription = clsLang.udfGetRes(clsLang.enLangRes.wiz_p2_Description);
            lbSelectSheet.Text = clsLang.udfGetRes(clsLang.enLangRes.wiz_p2_Selectsheet_text);

            wpPreviwe.PageTitle = clsLang.udfGetRes(clsLang.enLangRes.wiz_p3_Title);
            wpPreviwe.PageDescription = clsLang.udfGetRes(clsLang.enLangRes.wiz_p3_Description);
            lbImpline.Text = clsLang.udfGetRes(clsLang.enLangRes.wiz_p3_importline);
            lbEmailClm.Text = clsLang.udfGetRes(clsLang.enLangRes.wiz_p3_emailclm);

            lbstatus.Text=clsLang.udfGetRes(clsLang.enLangRes.wiz_p4_status_text);

            Wizard1.NextButtonText=clsLang.udfGetRes(clsLang.enLangRes.wiz_next);
            Wizard1.BackButtonText=clsLang.udfGetRes(clsLang.enLangRes.wiz_Back);
            Wizard1.CancelButtonText=clsLang.udfGetRes(clsLang.enLangRes.wiz_cancel);
            Wizard1.FinishButtonText=clsLang.udfGetRes(clsLang.enLangRes.wiz_finish);

            Text=clsLang.udfGetRes(clsLang.enLangRes.wiz_title);
        }
    }
}
