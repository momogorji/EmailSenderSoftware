using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMG_Soft_MailSender.UserCtrl
{
    public partial class cmbPriority : ComboBox
    {
        public cmbPriority()
        {
            InitializeComponent();

            base.DropDownStyle = ComboBoxStyle.DropDownList;            
        }

        public void udfLoad()
        {
            base.Items.Clear();
            base.Items.AddRange(Enum.GetNames(typeof(System.Net.Mail.MailPriority)).ToArray());
            base.SelectedIndex = 0;
        }
    }
}
