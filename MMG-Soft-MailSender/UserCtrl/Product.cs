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
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        public void udfLoadSite()
        {
            iWebBrowser.Navigate("http://www.ejens.com");
        }
    }
}
