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
    public partial class frmlicence : Form
    {
        public string licencetext { get; set; }

        public frmlicence()
        {
            InitializeComponent();
        }

        private void frmlicence_Load(object sender, EventArgs e)
        {
            txtlicence.Text = licencetext;
        }

        
    }
}
