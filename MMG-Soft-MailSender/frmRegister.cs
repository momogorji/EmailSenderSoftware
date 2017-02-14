using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MMG_Soft_MailSender.Class;

namespace MMG_Soft_MailSender
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        private bool m_validate = false;

        private void txtFName_Validating(object sender, CancelEventArgs e)
        {
            if (m_validate)
            {
                if (((Control)sender).Text == "")
                {
                    e.Cancel = true;
                }
            }
        }

        public bool udfChkRegistration()
        {
            string fil = Application.StartupPath + @"\user.xmx";

            if (System.IO.File.Exists(fil))
            {
                try
                {
                    ds.UserRegisterDataTable ureg = new ds.UserRegisterDataTable();

                    ureg.ReadXml(fil);

                    if (new clsHW().udfGetCPUId() != new clsENC().Decrypt(ureg[0].Key))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }                    
                }
                catch (Exception)
                {

                    return false;
                }
            }
            else
            {
                return false;
            }

            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            //if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            //{            
            //    MessageBox.Show(clsLang.udfGetRes(clsLang.enLangRes.Disconnect));
            //    btnSend.Enabled = true;
            //    return;
            //}

            m_validate = true;
            if (ValidateChildren())
            {                
                //send information by e-mail
                string uinf = "";
                string SN = new clsHW().udfGetCPUId();
                string Key = new clsENC().Encrypt(new clsHW().udfGetCPUId());
                Key = Key + "jdferigjkj343";
                Key = new clsENC().Encrypt(Key.ToString());

                Key = Key + "787ngjn-[]sdh12`1";
                Key = new clsENC().Encrypt(Key.ToString());
                Key = "-65jdsh" + Key + "sd009()23;dsd";
                Key = new clsENC().Encrypt(Key.ToString());
                //Key = new clsENC().Decrypt(Key.ToString());

//                Key = new clsENC().Decrypt(Key.ToString());

                uinf = Key + "," + txtFName.Text + "," + txtLName.Text + "," + txtCountry.Text + "," + txtProvince.Text + "," + txtCity.Text + "," + txteMail.Text + "," + txtPhoneNumber.Text + " shomarehfish= " + Receipt_Banktxt.Text + " tarikh ersal=" + DateTimeRecipdetxt.Text + " code shobeh=" + txtcodeshobeh.Text+" mablagh varizi="+txtprice.Text ;
             //   if (!new clsPostEmail().udfSendUserInformation(uinf))
                {
                    frmlicence i = new frmlicence();
                    i.licencetext = uinf;
                    i.ShowDialog();
                    


                  //  MessageBox.Show(clsLang.udfGetRes(clsLang.enLangRes.reg_ErroSendUserInfo));
                    btnSend.Enabled = true;
                    return;
                }

                

                //send user serianl number to user e-mail
                
                //if (!new clsPostEmail().udfSendUserActivationKey(Key, txteMail.Text))
                //{
                //    MessageBox.Show(clsLang.udfGetRes(clsLang.enLangRes.reg_ErrSendUserAK));
                //    btnSend.Enabled = true;
                //    return;
                //}
                ////show serial form
                frmInputText ib = new frmInputText(clsLang.udfGetRes(clsLang.enLangRes.reg_AK));
            lbTryGetAK:
                if (ib.ShowDialog() == DialogResult.OK)
                {
                    if (ib.udpValue != Key)
                    {
                        goto lbTryGetAK;
                    }                    
                }
                else
                {
                    return;
                    btnSend.Enabled = true;
                }
                //save user information
                string fil = Application.StartupPath + @"\user.xmx";
                ds.UserRegisterDataTable utbl = new ds.UserRegisterDataTable();
                ds.UserRegisterRow ur;
                if (!System.IO.File.Exists(fil))
                {
                    System.IO.File.Create(fil).Close();
                }
                else
                {
                    System.IO.File.Delete(fil);
                    System.IO.File.Create(fil).Close();
                }
                ur = utbl.NewUserRegisterRow();
                ur.City = txtCity.Text;
                ur.Country = txtCountry.Text;
                ur.EMail = txteMail.Text;
                ur.FName = txtFName.Text;
                ur.LName = txtLName.Text;
                ur.PhoneNumber = txtPhoneNumber.Text;
                ur.Province = txtProvince.Text;                
                ur.Key = Key;
                utbl.Rows.Add(ur);
                utbl.WriteXml(fil);

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(clsLang.udfGetRes(clsLang.enLangRes.reg_EnterInfo));
                btnSend.Enabled = true;
            }
            m_validate = false;
        }

        private void txteMail_Validating(object sender, CancelEventArgs e)
        {
            if (m_validate)
            {
                string inp=((Control)(sender)).Text;
                string reg = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                 + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                 + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                 + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

                if (!Regex.IsMatch(inp, reg))
                {
                    MessageBox.Show(clsLang.udfGetRes(clsLang.enLangRes.str_invalid_email));
                }
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            Text = clsLang.udfGetRes(clsLang.enLangRes.Register);
            btnSend.Text = clsLang.udfGetRes(clsLang.enLangRes.btn_send_text);
            lbFN.Text = clsLang.udfGetRes(clsLang.enLangRes.FName);
            lbLN.Text = clsLang.udfGetRes(clsLang.enLangRes.LName);
            lbCountry.Text = clsLang.udfGetRes(clsLang.enLangRes.Country);
            lbProvince.Text = clsLang.udfGetRes(clsLang.enLangRes.Province);
            lbCity.Text = clsLang.udfGetRes(clsLang.enLangRes.City);
            lbEMail.Text = clsLang.udfGetRes(clsLang.enLangRes.clm_Email);
            lbPhoneNumber.Text = clsLang.udfGetRes(clsLang.enLangRes.TellNumber);
            ReceiptInfolbl.Text = clsLang.udfGetRes(clsLang.enLangRes.ReceiptInfo);
            lblDateTimeReceipt.Text = clsLang.udfGetRes(clsLang.enLangRes.lblDateTimeReceipt);
            lblReceiptBank.Text = clsLang.udfGetRes(clsLang.enLangRes.lblReceiptBank);
            lblBranchCodelbl.Text = clsLang.udfGetRes(clsLang.enLangRes.lblBranchCodelbl);
            lblregisteredcode.Text = clsLang.udfGetRes(clsLang.enLangRes.lblregisteredcode);
            btnactivecode.Text = clsLang.udfGetRes(clsLang.enLangRes.btnactivecode);
            lblcoust.Text = clsLang.udfGetRes(clsLang.enLangRes.lblcoust);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SN = new clsHW().udfGetCPUId();
            string Key = new clsENC().Encrypt(new clsHW().udfGetCPUId());
              
            //show serial form
            frmInputText ib = new frmInputText(clsLang.udfGetRes(clsLang.enLangRes.reg_AK));
        lbTryGetAK:
            if (ib.ShowDialog() == DialogResult.OK)
            {
                if (ib.udpValue != Key)
                {
                    goto lbTryGetAK;
                }
            }
            else
            {
                return;
                btnSend.Enabled = true;
            }
           
              //save user information
                string fil = Application.StartupPath + @"\user.xmx";
                ds.UserRegisterDataTable utbl = new ds.UserRegisterDataTable();
                ds.UserRegisterRow ur;
                if (!System.IO.File.Exists(fil))
                {
                    System.IO.File.Create(fil).Close();
                }
                else
                {
                    System.IO.File.Delete(fil);
                    System.IO.File.Create(fil).Close();
                }
                ur = utbl.NewUserRegisterRow();
                ur.City = txtCity.Text;
                ur.Country = txtCountry.Text;
                ur.EMail = txteMail.Text;
                ur.FName = txtFName.Text;
                ur.LName = txtLName.Text;
                ur.PhoneNumber = txtPhoneNumber.Text;
                ur.Province = txtProvince.Text;                
                ur.Key = Key;
                utbl.Rows.Add(ur);
                utbl.WriteXml(fil);

                DialogResult = DialogResult.OK;
            
            

        }

    
    }
}

