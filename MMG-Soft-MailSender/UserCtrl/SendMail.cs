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
    public partial class SendMail : UserControl
    {
        public SendMail()
        {
            InitializeComponent();
        }

        public delegate void uddStartSend();
        public event uddStartSend udeStartSend;

        public delegate void uddSendComplate();
        public event uddSendComplate udeSendComplate;
       


        public int udpSenderProfileID { get; set; }
        public int udpRecipientsProfileId { get; set; }
        public int udpContentProfileID { get; set; }
        private bool m_stop = true;

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                System.Threading.Thread trd = new System.Threading.Thread(new System.Threading.ThreadStart(udfSend));
                trd.Start();

                new clsPostEmail().udfTrySend();
            }
            else
            {
                MessageBox.Show(clsLang.udfGetRes(clsLang.enLangRes.Disconnect));
            }
        }

        private void udfSend()
        {
            if (udeStartSend != null) { udeStartSend(); }

            ds.tblRecipientsItemsDataTable SendTo = new ds.tblRecipientsItemsDataTable();
            clsSendCenter SendCenter = new clsSendCenter();
            ds.tblContentRow icontent = new dsTableAdapters.tblContentTableAdapter().GetDataByProfileId(udpContentProfileID).Single();
            ds.tblSenderRow isender = new dsTableAdapters.tblSenderTableAdapter().GetDataByProfileID(udpSenderProfileID).Single();
            dsTableAdapters.tblSendLogTableAdapter qLog = new MMG_Soft_MailSender.dsTableAdapters.tblSendLogTableAdapter();
            bool ok=false;
            SendTo = new dsTableAdapters.tblRecipientsItemsTableAdapter().GetData(udpRecipientsProfileId);
            ds.tblSendLogDataTable tLog = new dsTableAdapters.tblSendLogTableAdapter().GetDataByValue(udpRecipientsProfileId, udpContentProfileID, udpSenderProfileID);
            List<string> sl = new List<string>();
            ds.tblSendLogRow logr;

            btnSend.Enabled = false;
            btnCancel.Enabled = true;

            using (tLog)
            {
                foreach (ds.tblRecipientsItemsRow r0 in SendTo)
                {
                    logr = tLog.Where(z => z.EmailAddress == r0.EmailAddress).FirstOrDefault();
                    if (logr != null)
                    {
                        if (logr.Status == (int)Class.clsPublic.enStatus.Send)
                        {
                            continue;
                        }
                    }
                    sl.Add(r0.EmailAddress);
                }
            }

            iProgressBar.Maximum = SendTo.Count;
            iProgressBar.Value =SendTo.Count- sl.Count;
            m_stop = false;

            //string adstext;
            //if (icontent.isHtml)
            //{ adstext = "<br/><br/><br/></div><div style='width:100%; float:right; border-top:1px solid  #CCCCCC; color:#999999; direction:rtl; text-decoration:none; font-family:tahoma; font-size:10px' >&#1575;&#1585;&#1587;&#1575;&#1604; &#1578;&#1608;&#1587;&#1591; :<a href='http://www.sms-soft.com/page/email_sender_marketing_software_free_download.html' target='_blank' style=' text-decoration:none;'> &#1606;&#1585;&#1605; &#1575;&#1601;&#1586;&#1575;&#1585; &#1575;&#1585;&#1587;&#1575;&#1604; &#1575;&#1740;&#1605;&#1740;&#1604; &#1711;&#1585;&#1608;&#1607;&#1740;</a>&nbsp;**<a href='http://www.sms-soft.com' target='_blank' style=' text-decoration:none; '>&#1606;&#1585;&#1605; &#1575;&#1601;&#1586;&#1575;&#1585; &#1575;&#1585;&#1587;&#1575;&#1604; &#1575;&#1587; &#1575;&#1605; &#1575;&#1587;</a>&nbsp;** <a href='http://www.ejens.com' target='_blank' style=' text-decoration:none; '>&#1575;&#1740;&#1580;&#1606;&#1587;  : &#1587;&#1575;&#1740;&#1578; &#1587;&#1575;&#1586;&#1740; &#1581;&#1585;&#1601;&#1607; &#1575;&#1740; &#1605;&#1585;&#1705;&#1586; &#1588;&#1585;&#1705;&#1578;&#1607;&#1575; &#1608; &#1601;&#1585;&#1608;&#1588;&#1606;&#1583;&#1711;&#1575;&#1606; &#1575;&#1740;&#1585;&#1575;&#1606;&#1740; </a>&nbsp;** <a href='http://www.bluetoothes.com' target='_blank' style=' text-decoration:none;'>&#1606;&#1585;&#1605; &#1575;&#1601;&#1586;&#1575;&#1585; &#1575;&#1585;&#1587;&#1575;&#1604; &#1576;&#1604;&#1608;&#1578;&#1608;&#1579; &#1578;&#1576;&#1604;&#1740;&#1594;&#1575;&#1578;&#1740; </a> </div>	"; }
            //else
            //{ adstext = "نرم افزار  ارسال ایمیل: www.sms-soft.com نرم افزار ارسال ارسال بلوتوث : www.bluetoothes.com ایجنس: سایت ساز حرفه ای,مرکز شرکتها وفروشندگان ایرانی"; }

            //check cpuid

            frmRegister freg = new frmRegister();

            if (!freg.udfChkRegistration())
            {
                icontent.Body = "<table cellspacing='0' cellpadding='0' border='0'><tbody><tr><td valign='top' style='font: inherit;'><div style='text-align: center;'><span style='font-family: tahoma, 'new york', times, serif; font-size: xx-large;'><br></span></div><div style='text-align: center;'><span style='font-family: tahoma, 'new york', times, serif; font-size: xx-large;'><b><a href='http://www.sms-soft.com/page/email_sender_marketing_software_free_download.html' target='_blank'>نرم افزار ارسال خبرنامه ایمیلی&nbsp;</a></b></span></div><div style='text-align: center;'><font face='tahoma, new york, times, serif' size='6'><a href='http://www.sms-soft.com/page/email_sender_marketing_software_free_download.html' target='_blank'>www.sms-soft.com</a></font></div><div style='text-align: center;'><span style='font-family: tahoma, 'new york', times, serif; font-size: xx-large;'><br></span></div></td></tr></tbody></table>";
                icontent.Subject = "نرم افزار ارسال خبرنامه";
            }

            foreach (string aSendTo in sl)
            {
                iProgressBar.Value += 1;
                lbSendTo.Text = string.Format(clsLang.udfGetRes(clsLang.enLangRes.lb_sendTo_text)+" {0}", aSendTo);
                
                ok = SendCenter.udfSendEmail(icontent.Subject
                    

                 //نرم افزار  ارسال ایمیل: www.sms-soft.com نرم افزار ارسال ارسال بلوتوث : www.bluetoothes.com ایجنس: سایت ساز حرفه ای,مرکز شرکتها وفروشندگان ایرانی
                    //, icontent.Body.Replace("/n", "<br/>") + "<br/><br/><br/></div><div style='width:100%; float:right; border-top:1px solid  #CCCCCC; color:#999999; direction:rtl; text-decoration:none; font-family:tahoma; font-size:10px' >&#1575;&#1585;&#1587;&#1575;&#1604; &#1578;&#1608;&#1587;&#1591; :<a href='http://www.sms-soft.com/page/email_sender_marketing_software_free_download.html' target='_blank' style=' text-decoration:none;'> &#1606;&#1585;&#1605; &#1575;&#1601;&#1586;&#1575;&#1585; &#1575;&#1585;&#1587;&#1575;&#1604; &#1575;&#1740;&#1605;&#1740;&#1604; &#1711;&#1585;&#1608;&#1607;&#1740;</a>&nbsp;**<a href='http://www.sms-soft.com' target='_blank' style=' text-decoration:none; '>&#1606;&#1585;&#1605; &#1575;&#1601;&#1586;&#1575;&#1585; &#1575;&#1585;&#1587;&#1575;&#1604; &#1575;&#1587; &#1575;&#1605; &#1575;&#1587;</a>&nbsp;** <a href='http://www.ejens.com' target='_blank' style=' text-decoration:none; '>&#1575;&#1740;&#1580;&#1606;&#1587;  : &#1587;&#1575;&#1740;&#1578; &#1587;&#1575;&#1586;&#1740; &#1581;&#1585;&#1601;&#1607; &#1575;&#1740; &#1605;&#1585;&#1705;&#1586; &#1588;&#1585;&#1705;&#1578;&#1607;&#1575; &#1608; &#1601;&#1585;&#1608;&#1588;&#1606;&#1583;&#1711;&#1575;&#1606; &#1575;&#1740;&#1585;&#1575;&#1606;&#1740; </a>&nbsp;** <a href='http://www.bluetoothes.com' target='_blank' style=' text-decoration:none;'>&#1606;&#1585;&#1605; &#1575;&#1601;&#1586;&#1575;&#1585; &#1575;&#1585;&#1587;&#1575;&#1604; &#1576;&#1604;&#1608;&#1578;&#1608;&#1579; &#1578;&#1576;&#1604;&#1740;&#1594;&#1575;&#1578;&#1740; </a> </div>	"
                    , icontent.Body.Replace("\n", "<br/>") 
                   // , icontent.Body + adstext
                    , isender.FromAddress
                    , isender.DisplayName
                    , aSendTo
                    , isender.ServerPort
                    , isender.SMTP_Server
                    , isender.UserName
                    , isender.Password
                    , isender.UseSSL
                    , isender.SleepInterval
                    ,isender.CustomHeader
                  //  ,icontent.isHtml
                    ,true
                    ,null);

                //save log
                qLog.Delete(udpRecipientsProfileId, udpContentProfileID, udpSenderProfileID, aSendTo);
                qLog.Insert(udpRecipientsProfileId
                    , udpContentProfileID
                    ,udpSenderProfileID 
                    , aSendTo                    
                    , Convert.ToByte(ok == true ? 1 : 2));
                lbResualt.Text = clsLang.udfGetRes(clsLang.enLangRes.lb_Reault_text) + (ok ? " Ok" : " Failed");
                Application.DoEvents();
                if (m_stop) { break; }

                if (!ok)
                {
                    if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                    {

                        MessageBox.Show(clsLang.udfGetRes(clsLang.enLangRes.Disconnect));
                        break;
                    }
                }
                
            }

            btnSend.Enabled = true;
            btnCancel.Enabled = false;
            lbSendTo.Text = clsLang.udfGetRes(clsLang.enLangRes.str_send_complate);
            lbResualt.Text = "";
            iProgressBar.Value = 0;
            if (udeSendComplate != null)
            {
                udeSendComplate();
            }
            btnSend.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            
            m_stop = true;
        }

        public void udfSetInfo(string Sender,string Receipeints,string Content)
        {
            btnSend.Enabled = true;
            if (Content == "") { btnSend.Enabled = false; Content = clsLang.udfGetRes(clsLang.enLangRes.wrn_Select_content); }
            if (Receipeints == "") { btnSend.Enabled = false; Receipeints = clsLang.udfGetRes(clsLang.enLangRes.wrn_Select_receipients); }
            if (Sender == "") { btnSend.Enabled = false; Sender = clsLang.udfGetRes(clsLang.enLangRes.wrn_select_sender); }


            lbContentValue.Text = Content;
            lbReceipientsValue.Text =  Receipeints;
            lbSenderValue.Text =  Sender;
            

        }

        

        

        public void udfRefreshInterface()
        {            
            lbSendMail.Text = clsLang.udfGetRes(clsLang.enLangRes.SendMail);            
            
            lbSender.Text = clsLang.udfGetRes(clsLang.enLangRes.lb_sender_text);            
            lbReceipient.Text = clsLang.udfGetRes(clsLang.enLangRes.lb_Receipients_text);            
            lbContent.Text = clsLang.udfGetRes(clsLang.enLangRes.lb_Content_text);                                   
            btnSend.Text = clsLang.udfGetRes(clsLang.enLangRes.btn_send_text);            
            
            btnCancel.Text = clsLang.udfGetRes(clsLang.enLangRes.btn_cancel_text);            
            

            lbSendTo.Text = clsLang.udfGetRes(clsLang.enLangRes.lb_sendTo_text);
            lbResualt.Text = clsLang.udfGetRes(clsLang.enLangRes.lb_Reault_text);

            
        }
        
    }
}
