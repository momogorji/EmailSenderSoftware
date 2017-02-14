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
    public partial class frmInputText : Form
    {
        public frmInputText(string Titlle)
        {
            InitializeComponent();
            label1.Text = Titlle;

            Text =clsLang.udfGetRes(clsLang.enLangRes.inp_PlzEnter) ;


        }



        public string udpValue
        {
            get { return txtHeadesr.Text.TrimEnd(' ').TrimStart(' '); }
            set { txtHeadesr.Text = value; }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}

