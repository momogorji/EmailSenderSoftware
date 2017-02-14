using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMG_Soft_MailSender
{
    public partial class frmLanguageOption : Form
    {
        public frmLanguageOption()
        {
            InitializeComponent();
        }

        private List<string> m_Lang = new List<string>();

        

        private void frmLanguageOption_Load(object sender, EventArgs e)
        {
            try
            {
                string ss = "";
                foreach (string a in System.IO.Directory.GetFiles(Application.StartupPath + @"\Lang"))
                {
                    if (System.IO.Path.GetExtension(a).ToLower() == ".txt")
                    {
                        ss = System.IO.File.OpenText(a).ReadLine();
                        lstLanguage.Items.Add(ss);
                        m_Lang.Add(System.IO.Path.GetFileNameWithoutExtension(a));
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnAccep_Click(object sender, EventArgs e)
        {
            if (lstLanguage.SelectedIndex != -1)
            {
                Properties.Settings.Default.DefaultLanguage = m_Lang[lstLanguage.SelectedIndex];
                Properties.Settings.Default.Save();

                //reload dictionary
                Class.clsLang.udfLoadBaseRes();

                DialogResult = DialogResult.OK;
            } 
        }
    }
}
