using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MMG_Soft_MailSender
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.DefaultLanguage == "")
            {
                frmLanguageOption f = new frmLanguageOption();

                if (f.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                
            }

            Class.clsLang.udfLoadBaseRes();

            Application.Run(new frmMain());
        }
    }
}
