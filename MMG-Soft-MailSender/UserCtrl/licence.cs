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
    public partial class licence : UserControl
    {
        public licence()
        {
            InitializeComponent();
        }

        public void udfRefreshInterface()
        {
            lbllicenceactive.Text = clsLang.udfGetRes(clsLang.enLangRes.licenceactive);
          
        }
    }
}
