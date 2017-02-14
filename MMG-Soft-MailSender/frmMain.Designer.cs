namespace MMG_Soft_MailSender
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.sideBar1 = new DevComponents.DotNetBar.SideBar();
            this.sbpNavigation = new DevComponents.DotNetBar.SideBarPanelItem();
            this.btnSenderProfile = new DevComponents.DotNetBar.ButtonItem();
            this.btnRecipients = new DevComponents.DotNetBar.ButtonItem();
            this.btnContent = new DevComponents.DotNetBar.ButtonItem();
            this.btnSendMail = new DevComponents.DotNetBar.ButtonItem();
            this.btnAbout = new DevComponents.DotNetBar.ButtonItem();
            this.btnProduct = new DevComponents.DotNetBar.ButtonItem();
            this.btnlicence = new DevComponents.DotNetBar.ButtonItem();
            this.pnCountiner = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.ribbonTabItemGroup1 = new DevComponents.DotNetBar.RibbonTabItemGroup();
            this.iMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLanguageOption = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.uslicence = new MMG_Soft_MailSender.UserCtrl.licence();
            this.usSenderProfile = new MMG_Soft_MailSender.UserCtrl.SenderProfile();
            this.usContent = new MMG_Soft_MailSender.UserCtrl.Content();
            this.usMailSender = new MMG_Soft_MailSender.UserCtrl.SendMail();
            this.usRecipients = new MMG_Soft_MailSender.UserCtrl.Recipients();
            this.usAbout = new MMG_Soft_MailSender.UserCtrl.About();
            this.usProduct = new MMG_Soft_MailSender.UserCtrl.Product();
            this.sendMail1 = new MMG_Soft_MailSender.UserCtrl.SendMail();
            this.sendMail2 = new MMG_Soft_MailSender.UserCtrl.SendMail();
            this.sendMail3 = new MMG_Soft_MailSender.UserCtrl.SendMail();
            this.sendMail4 = new MMG_Soft_MailSender.UserCtrl.SendMail();
            this.pnCountiner.SuspendLayout();
            this.iMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar1
            // 
            this.sideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.sideBar1.AllowDrop = true;
            this.sideBar1.AllowExternalDrop = true;
            this.sideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None;
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar1.ExpandedPanel = this.sbpNavigation;
            this.sideBar1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.sideBar1.Location = new System.Drawing.Point(0, 24);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Panels.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sbpNavigation});
            this.sideBar1.Size = new System.Drawing.Size(142, 609);
            this.sideBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.sideBar1.TabIndex = 1;
            this.sideBar1.TabStop = false;
            this.sideBar1.UseNativeDragDrop = true;
            // 
            // sbpNavigation
            // 
            this.sbpNavigation.FontBold = true;
            this.sbpNavigation.ItemImageSize = DevComponents.DotNetBar.eBarImageSize.Medium;
            this.sbpNavigation.Name = "sbpNavigation";
            this.sbpNavigation.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSenderProfile,
            this.btnRecipients,
            this.btnContent,
            this.btnSendMail,
            this.btnAbout,
            this.btnProduct,
            this.btnlicence});
            this.sbpNavigation.Text = "Navigation";
            // 
            // btnSenderProfile
            // 
            this.btnSenderProfile.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSenderProfile.Checked = true;
            this.btnSenderProfile.Image = global::MMG_Soft_MailSender.Properties.Resources._1309075416_download;
            this.btnSenderProfile.ImageIndex = 0;
            this.btnSenderProfile.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSenderProfile.Name = "btnSenderProfile";
            this.btnSenderProfile.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
            this.btnSenderProfile.Text = "Sender";
            this.btnSenderProfile.Click += new System.EventHandler(this.btnSenderProfile_Click);
            // 
            // btnRecipients
            // 
            this.btnRecipients.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnRecipients.Image = global::MMG_Soft_MailSender.Properties.Resources._1309075310_address_book;
            this.btnRecipients.ImageIndex = 1;
            this.btnRecipients.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRecipients.Name = "btnRecipients";
            this.btnRecipients.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
            this.btnRecipients.Text = "Recipients";
            this.btnRecipients.Click += new System.EventHandler(this.btnRecipients_Click);
            // 
            // btnContent
            // 
            this.btnContent.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnContent.Image = global::MMG_Soft_MailSender.Properties.Resources._1309075338_edit_notes;
            this.btnContent.ImageIndex = 2;
            this.btnContent.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnContent.Name = "btnContent";
            this.btnContent.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
            this.btnContent.Text = "Content";
            this.btnContent.Click += new System.EventHandler(this.btnContent_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSendMail.Image = global::MMG_Soft_MailSender.Properties.Resources._1309075264_send_group;
            this.btnSendMail.ImageIndex = 3;
            this.btnSendMail.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnAbout.Image = global::MMG_Soft_MailSender.Properties.Resources._1309240189_info_blog;
            this.btnAbout.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnProduct.Image = global::MMG_Soft_MailSender.Properties.Resources._1309241033_kpackage;
            this.btnProduct.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Text = "Product";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnlicence
            // 
            this.btnlicence.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnlicence.Image = ((System.Drawing.Image)(resources.GetObject("btnlicence.Image")));
            this.btnlicence.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnlicence.Name = "btnlicence";
            this.btnlicence.Text = "licence";
            this.btnlicence.Click += new System.EventHandler(this.btnlicence_Click);
            // 
            // pnCountiner
            // 
            this.pnCountiner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCountiner.Controls.Add(this.uslicence);
            this.pnCountiner.Controls.Add(this.btnPrev);
            this.pnCountiner.Controls.Add(this.btnNext);
            this.pnCountiner.Controls.Add(this.usSenderProfile);
            this.pnCountiner.Controls.Add(this.usContent);
            this.pnCountiner.Controls.Add(this.usMailSender);
            this.pnCountiner.Controls.Add(this.usRecipients);
            this.pnCountiner.Controls.Add(this.usAbout);
            this.pnCountiner.Controls.Add(this.usProduct);
            this.pnCountiner.Location = new System.Drawing.Point(146, 25);
            this.pnCountiner.Name = "pnCountiner";
            this.pnCountiner.Size = new System.Drawing.Size(625, 606);
            this.pnCountiner.TabIndex = 2;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.Enabled = false;
            this.btnPrev.Image = global::MMG_Soft_MailSender.Properties.Resources._1309239079_Previous;
            this.btnPrev.Location = new System.Drawing.Point(532, 16);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(42, 39);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Image = global::MMG_Soft_MailSender.Properties.Resources._1309238988_Next;
            this.btnNext.Location = new System.Drawing.Point(574, 16);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 39);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ribbonTabItemGroup1
            // 
            this.ribbonTabItemGroup1.Color = DevComponents.DotNetBar.eRibbonTabGroupColor.Orange;
            this.ribbonTabItemGroup1.GroupTitle = "Tab Group";
            this.ribbonTabItemGroup1.Name = "ribbonTabItemGroup1";
            // 
            // 
            // 
            this.ribbonTabItemGroup1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.ribbonTabItemGroup1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.ribbonTabItemGroup1.Style.BackColorGradientAngle = 90;
            this.ribbonTabItemGroup1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderBottomWidth = 1;
            this.ribbonTabItemGroup1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(58)))), ((int)(((byte)(59)))));
            this.ribbonTabItemGroup1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderLeftWidth = 1;
            this.ribbonTabItemGroup1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderRightWidth = 1;
            this.ribbonTabItemGroup1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonTabItemGroup1.Style.BorderTopWidth = 1;
            this.ribbonTabItemGroup1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonTabItemGroup1.Style.TextColor = System.Drawing.Color.Black;
            this.ribbonTabItemGroup1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // iMenuStrip
            // 
            this.iMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFile});
            this.iMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.iMenuStrip.Name = "iMenuStrip";
            this.iMenuStrip.Size = new System.Drawing.Size(773, 24);
            this.iMenuStrip.TabIndex = 3;
            this.iMenuStrip.Text = "menuStrip1";
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLanguageOption,
            this.exitToolStripMenuItem,
            this.btnExit});
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(35, 20);
            this.mnFile.Text = "File";
            // 
            // btnLanguageOption
            // 
            this.btnLanguageOption.Name = "btnLanguageOption";
            this.btnLanguageOption.Size = new System.Drawing.Size(156, 22);
            this.btnLanguageOption.Text = "Language Option";
            this.btnLanguageOption.Click += new System.EventHandler(this.btnLanguageOption_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // uslicence
            // 
            this.uslicence.BackColor = System.Drawing.Color.White;
            this.uslicence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uslicence.Location = new System.Drawing.Point(0, 0);
            this.uslicence.Name = "uslicence";
            this.uslicence.Size = new System.Drawing.Size(625, 606);
            this.uslicence.TabIndex = 7;
            // 
            // usSenderProfile
            // 
            this.usSenderProfile.BackColor = System.Drawing.Color.White;
            this.usSenderProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usSenderProfile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usSenderProfile.Location = new System.Drawing.Point(0, 0);
            this.usSenderProfile.Name = "usSenderProfile";
            this.usSenderProfile.Size = new System.Drawing.Size(625, 606);
            this.usSenderProfile.TabIndex = 1;
            this.usSenderProfile.udeProfileSelected += new MMG_Soft_MailSender.UserCtrl.SenderProfile.uddProfileSelected(this.usSenderProfile_udeProfileSelected);
            // 
            // usContent
            // 
            this.usContent.BackColor = System.Drawing.Color.White;
            this.usContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usContent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usContent.Location = new System.Drawing.Point(0, 0);
            this.usContent.Name = "usContent";
            this.usContent.Size = new System.Drawing.Size(625, 606);
            this.usContent.TabIndex = 0;
            this.usContent.udeProfileSelected += new MMG_Soft_MailSender.UserCtrl.Content.uddProfileSelected(this.usContent_udeProfileSelected);
            // 
            // usMailSender
            // 
            this.usMailSender.BackColor = System.Drawing.Color.White;
            this.usMailSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usMailSender.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usMailSender.Location = new System.Drawing.Point(0, 0);
            this.usMailSender.Name = "usMailSender";
            this.usMailSender.Size = new System.Drawing.Size(625, 606);
            this.usMailSender.TabIndex = 3;
            this.usMailSender.udpContentProfileID = 0;
            this.usMailSender.udpRecipientsProfileId = 0;
            this.usMailSender.udpSenderProfileID = 0;
            this.usMailSender.udeSendComplate += new MMG_Soft_MailSender.UserCtrl.SendMail.uddSendComplate(this.usMailSender_udeSendComplate);
            this.usMailSender.udeStartSend += new MMG_Soft_MailSender.UserCtrl.SendMail.uddStartSend(this.usMailSender_udeStartSend);
            // 
            // usRecipients
            // 
            this.usRecipients.BackColor = System.Drawing.Color.White;
            this.usRecipients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usRecipients.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usRecipients.Location = new System.Drawing.Point(0, 0);
            this.usRecipients.Name = "usRecipients";
            this.usRecipients.Size = new System.Drawing.Size(625, 606);
            this.usRecipients.TabIndex = 6;
            this.usRecipients.udpContentID = 0;
            this.usRecipients.udpSenderID = 0;
            // 
            // usAbout
            // 
            this.usAbout.BackColor = System.Drawing.Color.White;
            this.usAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usAbout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usAbout.Location = new System.Drawing.Point(0, 0);
            this.usAbout.Name = "usAbout";
            this.usAbout.Size = new System.Drawing.Size(625, 606);
            this.usAbout.TabIndex = 4;
            // 
            // usProduct
            // 
            this.usProduct.BackColor = System.Drawing.Color.White;
            this.usProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.usProduct.Location = new System.Drawing.Point(0, 0);
            this.usProduct.Name = "usProduct";
            this.usProduct.Size = new System.Drawing.Size(625, 606);
            this.usProduct.TabIndex = 5;
            // 
            // sendMail1
            // 
            this.sendMail1.BackColor = System.Drawing.Color.Transparent;
            this.sendMail1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sendMail1.Location = new System.Drawing.Point(0, 0);
            this.sendMail1.Name = "sendMail1";
            this.sendMail1.Size = new System.Drawing.Size(561, 399);
            this.sendMail1.TabIndex = 0;
            this.sendMail1.udpContentProfileID = 0;
            this.sendMail1.udpRecipientsProfileId = 0;
            this.sendMail1.udpSenderProfileID = 0;
            // 
            // sendMail2
            // 
            this.sendMail2.BackColor = System.Drawing.Color.Transparent;
            this.sendMail2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sendMail2.Location = new System.Drawing.Point(0, 0);
            this.sendMail2.Name = "sendMail2";
            this.sendMail2.Size = new System.Drawing.Size(561, 399);
            this.sendMail2.TabIndex = 0;
            this.sendMail2.udpContentProfileID = 0;
            this.sendMail2.udpRecipientsProfileId = 0;
            this.sendMail2.udpSenderProfileID = 0;
            // 
            // sendMail3
            // 
            this.sendMail3.BackColor = System.Drawing.Color.Transparent;
            this.sendMail3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sendMail3.Location = new System.Drawing.Point(0, 0);
            this.sendMail3.Name = "sendMail3";
            this.sendMail3.Size = new System.Drawing.Size(561, 399);
            this.sendMail3.TabIndex = 0;
            this.sendMail3.udpContentProfileID = 0;
            this.sendMail3.udpRecipientsProfileId = 0;
            this.sendMail3.udpSenderProfileID = 0;
            // 
            // sendMail4
            // 
            this.sendMail4.BackColor = System.Drawing.Color.Transparent;
            this.sendMail4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sendMail4.Location = new System.Drawing.Point(0, 0);
            this.sendMail4.Name = "sendMail4";
            this.sendMail4.Size = new System.Drawing.Size(561, 399);
            this.sendMail4.TabIndex = 0;
            this.sendMail4.udpContentProfileID = 0;
            this.sendMail4.udpRecipientsProfileId = 0;
            this.sendMail4.udpSenderProfileID = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(773, 633);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.pnCountiner);
            this.Controls.Add(this.iMenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.iMenuStrip;
            this.MinimumSize = new System.Drawing.Size(713, 460);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MMG SOFT Mail Sender";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnCountiner.ResumeLayout(false);
            this.iMenuStrip.ResumeLayout(false);
            this.iMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.SideBar sideBar1;
        private DevComponents.DotNetBar.SideBarPanelItem sbpNavigation;
        private DevComponents.DotNetBar.ButtonItem btnSenderProfile;
        private DevComponents.DotNetBar.ButtonItem btnRecipients;
        private DevComponents.DotNetBar.ButtonItem btnContent;
        private DevComponents.DotNetBar.ButtonItem btnSendMail;
        private System.Windows.Forms.Panel pnCountiner;
        private MMG_Soft_MailSender.UserCtrl.Content usContent;
        private MMG_Soft_MailSender.UserCtrl.SenderProfile usSenderProfile;
        private MMG_Soft_MailSender.UserCtrl.SendMail sendMail1;
        private MMG_Soft_MailSender.UserCtrl.SendMail sendMail2;
        private MMG_Soft_MailSender.UserCtrl.SendMail sendMail3;
        private MMG_Soft_MailSender.UserCtrl.SendMail sendMail4;
        private MMG_Soft_MailSender.UserCtrl.SendMail usMailSender;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private DevComponents.DotNetBar.ButtonItem btnAbout;
        private DevComponents.DotNetBar.ButtonItem btnProduct;
        private MMG_Soft_MailSender.UserCtrl.About usAbout;
        private MMG_Soft_MailSender.UserCtrl.Product usProduct;
      
        
        private DevComponents.DotNetBar.RibbonTabItemGroup ribbonTabItemGroup1;
        private System.Windows.Forms.MenuStrip iMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem btnLanguageOption;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private MMG_Soft_MailSender.UserCtrl.Recipients usRecipients;
        private DevComponents.DotNetBar.ButtonItem btnlicence;
        private MMG_Soft_MailSender.UserCtrl.licence uslicence;

    }
}

