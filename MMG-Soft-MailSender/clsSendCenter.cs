using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace MMG_Soft_MailSender
{
   public class clsSendCenter
    {

       

        public bool udfSendEmail(string Subject,string Body,string From,string DisplayName,string To,int ServerPort,string Host,string UserName,string Password,bool SSL,int Sleep,string CustomeHeades,bool isHtml,string[] AttFile)
        {
            try
            {                
                MailMessage mail = new MailMessage();
                mail.Subject = Subject;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = Body;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = isHtml;
                mail.From = new MailAddress(From, DisplayName, System.Text.Encoding.GetEncoding("windows-1256"));
                mail.To.Add(To);

                if (AttFile != null)
                {
                    foreach (string att in AttFile)
                    {
                        mail.Attachments.Add(new Attachment(att));
                    }
                }

                foreach(string s in CustomeHeades.Split(Environment.NewLine.ToCharArray()))
                {
                    if (s.Contains(':'))
                    {
                        mail.Headers.Add(s.Split(':')[0], s.Split(':')[1]);
                    }
                }

                SmtpClient smtp = new SmtpClient();
                smtp.Port = ServerPort;
                smtp.Host = Host;      
                
                smtp.Credentials = new NetworkCredential(UserName, Password);
                //smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = SSL;
                smtp.Send(mail);
                System.Threading.Thread.Sleep(Sleep*1000);
                return true;
            }
            catch (Exception ex)
            {
                return false;                
            }

        }
    }
}
