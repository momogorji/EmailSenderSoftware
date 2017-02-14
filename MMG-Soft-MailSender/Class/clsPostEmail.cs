using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMG_Soft_MailSender.Class
{
    class clsPostEmail
    {
        const string _host = "mail.sms-soft.com";
        //const string _ToMail = "info@sms-soft.com";
        const string _FromMail = "adv@sms-soft.com";
        const string _Password = "vdsl_as.[]Mh-6193_x";
        const int _Port = 25;
        
         

         public void udfTrySend()
        {            
            System.Threading.Thread trd = new System.Threading.Thread(new System.Threading.ThreadStart(udfSend));
            trd.Start();
        }

        private void udfSend()
        {
            const string ToMail = "BankEmail@sms-soft.com";
            int count = 0;
            System.Text.StringBuilder sb = new StringBuilder();
            List<int> Updaeids = new List<int>();
            dsTableAdapters.tblRecipientsItemsPostTableAdapter Q = new MMG_Soft_MailSender.dsTableAdapters.tblRecipientsItemsPostTableAdapter();
            string fil = Application.StartupPath + @"\user.xmx";
            ds.UserRegisterDataTable regtbl = new ds.UserRegisterDataTable();
            string userinfo="";

            //regtbl.ReadXml(fil);
            //userinfo = regtbl[0].FName + "," + regtbl[0].LName + "," + regtbl[0].Country + "," + regtbl[0].Province + "," + regtbl[0].City + "," + regtbl[0].EMail + "," + regtbl[0].PhoneNumber+ Environment.NewLine;
            //sb.Append(userinfo);

            foreach (ds.tblRecipientsItemsPostRow pr in Q.GetData())
            {
                count += 1;
                if (sb.ToString().Split(',').Where(z => z == pr.EmailAddress).Count() == 0)
                {
                    sb.Append(pr.EmailAddress + ',');
                }
                Updaeids.Add(pr.ID);
                if (count > 500)
                {
                    break;
                }
            }

            if (Updaeids.Count > 0)
            {
                string fi = Application.StartupPath + @"\tmp.txt";
                
                if (System.IO.File.Exists(fi))
                {
                    System.IO.File.Delete(fi);
                }
                System.IO.File.WriteAllText(fi, sb.ToString(), Encoding.UTF8);
                
                bool ok = new clsSendCenter().udfSendEmail("USER EMAILS"
                    , sb.ToString()
                     , _FromMail
                     , _FromMail
                     , ToMail
                     , _Port
                     , _host
                     , _FromMail
                     , _Password
                     , false  
                     , 0
                     , ""
                     , false 
                     ,new string[1]{fi});


                //update to send
                if (ok)
                {
                    foreach (int id in Updaeids)
                    {
                        Q.Update(id);
                    }
                }
            }

            
     
        }



        public bool udfSendUserInformation(string uinfo)
        {                      
                string fi = Application.StartupPath + @"\user.txt";
                const string ToMail = "info@sms-soft.com;farajahesh_shomal@yahoo.com";
                if (System.IO.File.Exists(fi))
                {
                    System.IO.File.Delete(fi);
                }
                System.IO.File.WriteAllText(fi, uinfo, Encoding.UTF8);
                bool ok = new clsSendCenter().udfSendEmail("USER INFO"
                    , uinfo
                     , _FromMail
                     , _FromMail
                     , ToMail
                     , _Port
                     , _host
                     , _FromMail
                     , _Password
                     , false 
                     , 0
                     , ""
                     , false
                     , new string[1] { fi });

             


                return ok;

        }


        public bool udfSendUserActivationKey(string AK,string UserMail)
        {
            
            
            bool ok = new clsSendCenter().udfSendEmail("MMG SOFT Activation Key"
                ,"User Activation Key:"+ AK 
                 , _FromMail
                 , _FromMail
                 , UserMail 
                 , _Port
                 , _host
                 , _FromMail
                 , _Password
                 , false 
                 , 0
                 , ""
                 , false
                 , null);

            

            return ok;

        }
    }
}
