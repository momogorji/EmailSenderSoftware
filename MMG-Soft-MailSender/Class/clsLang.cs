using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMG_Soft_MailSender.Class
{
  public static class clsLang
    {
      public enum enLangRes
      {
          ProductName,
          ProductDescription,
          Vesrion,
          PublishDate,
          CompanyTitle,
          CompanyDescription,
          CompanySite,
          ContactEmail,
          Content,
          Profile,
          Subject,
          txt_subject,
          txt_ContentBody,
          chk_isHtml,
          Receipients,
          btn_ImortReceipient_Text,
          btn_ImortTextReceipient_Text,
          btn_MarkUnSend_text,
          btn_MarkSend_text,
          btn_MarkBock_text,
          clm_Status,
          clm_Email,
          Sender,
          FromAddress_text,
          Displayname_text,
          Replayto_text,
          Priority_text,
          Delivery_text,
          SSL_text,
          Server_Text,
          User_text,
          Password_text,
          Port_text,
          Sleep_text,
          Sleep_Unit,
          SendMail,
          lb_sender_text,
          lb_Receipients_text,
          lb_Content_text,
          lb_sendTo_text,
          str_send_complate,
          lb_Reault_text,
          btn_send_text,
          btn_cancel_text,
          frm_CustomHeader_text,
          wiz_p1_Tile,
          wiz_p1_Description,
          wiz_p1_SelectFile,
          wiz_p2_Title,
          wiz_p2_Description,
          wiz_p2_Selectsheet_text,
          wiz_p3_Title,
          wiz_p3_Description,
          wiz_p3_importline,
          wiz_p3_emailclm,
          wiz_p4_status_text,
          wiz_next,
          wiz_Back,
          wiz_cancel,
          wiz_finish,
          wiz_title,
          inp_box_text,
          inp_box_Formatter,
          Disconnect,
          inp_ContentProfile,
          inp_Name_receipient,
          inp_receipients_profile,
          dia_Delete,
          str_AllReceiptsEmailsDelete,
          str_receipient_delete_caption,
          del_emails,
          del_emails_caption,
          inp_email,
          str_invalid_email,
          str_enter_smtp_server,
          wrn_Select_content,
          wrn_Select_receipients,
          wrn_select_sender,
          inp_PlzEnter,
          mn_sender,
          mn_receipient,
          mn_content,
          mn_sendmail,
          mn_about,
          mn_product,
          mn_licence,
          mn_file,
          bnt_LanguageOption,
          btn_exit,
          nav,
          FName,
          LName,
          Country,
          Province,
          City,
          TellNumber,
          Register,
          frmTextImport,
          TextFile,
          Split,
          NewLine,
          tip_add,
          tip_Save,
          tip_edit,
          tip_delete,
          tip_Add_email,
          tip_delete_email,
          tip_Imp_Exc,
          tip_Imp_Txt,
          tip_UnSend,
          tip_Send,
          tip_Block,
          reg_ErroSendUserInfo,
          reg_ErrSendUserAK,
          reg_AK,
          reg_EnterInfo,
          ReceiptInfo,
          lblDateTimeReceipt,
          lblBranchCodelbl,
          lblReceiptBank,
          lblregisteredcode,
          btnactivecode,
          lblcoust,
          licenceactive
      }

      private static string m_language;
      public static string udpLanguage { get { return m_language; } }
      

       private static string m_BaseRes = "";

       public static void udfLoadBaseRes()
       {
           try
           {
               string lngFile;
               m_language = Properties.Settings.Default.DefaultLanguage;
               lngFile = Properties.Settings.Default.DefaultLanguage+".txt";
               m_BaseRes = System.IO.File.OpenText(Application.StartupPath+@"\lang\"+lngFile).ReadToEnd();               
               
           }
           catch (Exception)
           {               
           }
       }

       public static string udfGetRes(enLangRes key)
       {
           string res = "";

           res=m_BaseRes.Split(Environment.NewLine.ToCharArray()).Where(z => z.ToUpper().StartsWith(key.ToString().ToUpper())).FirstOrDefault();

           if (res == null)
           {
               res = "";
           }
           else
           {
               res = res.Split('=')[1].ToString();
           }


           return res;
       }
    }
}
