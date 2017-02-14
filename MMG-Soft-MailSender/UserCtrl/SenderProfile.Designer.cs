namespace MMG_Soft_MailSender.UserCtrl
{
    partial class SenderProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenderProfile));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbProfile = new System.Windows.Forms.Label();
            this.cmbProfile = new System.Windows.Forms.ComboBox();
            this.tblSenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new MMG_Soft_MailSender.ds();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.chkUseSSL = new System.Windows.Forms.CheckBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lbReplay = new System.Windows.Forms.Label();
            this.txtReplay = new System.Windows.Forms.TextBox();
            this.cmbPriority = new MMG_Soft_MailSender.UserCtrl.cmbPriority();
            this.lbPriority = new System.Windows.Forms.Label();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbSMTP = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new DevComponents.Editors.IntegerInput();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbSleepunit = new System.Windows.Forms.Label();
            this.lbPw = new System.Windows.Forms.Label();
            this.txtSleepInterval = new DevComponents.Editors.IntegerInput();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbSleep = new System.Windows.Forms.Label();
            this.tblSenderTableAdapter = new MMG_Soft_MailSender.dsTableAdapters.tblSenderTableAdapter();
            this.iErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSender = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.iToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSleepInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iErr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtHelp);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbProfile);
            this.groupBox2.Controls.Add(this.cmbProfile);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(9, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 51);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profiles";
            // 
            // lbProfile
            // 
            this.lbProfile.Location = new System.Drawing.Point(6, 21);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(87, 16);
            this.lbProfile.TabIndex = 0;
            this.lbProfile.Text = "Profile";
            this.lbProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbProfile
            // 
            this.cmbProfile.DataSource = this.tblSenderBindingSource;
            this.cmbProfile.DisplayMember = "ProfileName";
            this.cmbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbProfile.FormattingEnabled = true;
            this.cmbProfile.Location = new System.Drawing.Point(101, 16);
            this.cmbProfile.Name = "cmbProfile";
            this.cmbProfile.Size = new System.Drawing.Size(220, 27);
            this.cmbProfile.TabIndex = 0;
            this.cmbProfile.ValueMember = "ID";
            this.cmbProfile.SelectedIndexChanged += new System.EventHandler(this.cmbProfile_SelectedIndexChanged);
            // 
            // tblSenderBindingSource
            // 
            this.tblSenderBindingSource.DataMember = "tblSender";
            this.tblSenderBindingSource.DataSource = this.ds;
            this.tblSenderBindingSource.PositionChanged += new System.EventHandler(this.tblSenderBindingSource_PositionChanged);
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(327, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(33, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(360, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(33, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::MMG_Soft_MailSender.Properties.Resources._1308978920_001_01;
            this.btnNew.Location = new System.Drawing.Point(426, 15);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(33, 29);
            this.btnNew.TabIndex = 4;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::MMG_Soft_MailSender.Properties.Resources._1308979161_disk;
            this.btnSave.Location = new System.Drawing.Point(393, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(33, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHelp.BackColor = System.Drawing.Color.White;
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtHelp.Location = new System.Drawing.Point(480, 15);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHelp.Size = new System.Drawing.Size(205, 361);
            this.txtHelp.TabIndex = 34;
            this.txtHelp.TabStop = false;
            this.txtHelp.Text = resources.GetString("txtHelp.Text");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFrom);
            this.groupBox3.Controls.Add(this.lbFrom);
            this.groupBox3.Controls.Add(this.lbDisplay);
            this.groupBox3.Controls.Add(this.chkUseSSL);
            this.groupBox3.Controls.Add(this.txtDisplay);
            this.groupBox3.Controls.Add(this.lbReplay);
            this.groupBox3.Controls.Add(this.txtReplay);
            this.groupBox3.Controls.Add(this.cmbPriority);
            this.groupBox3.Controls.Add(this.lbPriority);
            this.groupBox3.Controls.Add(this.chkDelivery);
            this.groupBox3.Location = new System.Drawing.Point(9, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 164);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sender Information";
            // 
            // txtFrom
            // 
            this.txtFrom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSenderBindingSource, "FromAddress", true));
            this.txtFrom.Location = new System.Drawing.Point(116, 22);
            this.txtFrom.MaxLength = 50;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(151, 23);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.Validated += new System.EventHandler(this.udfValidated);
            this.txtFrom.Validating += new System.ComponentModel.CancelEventHandler(this.txtFrom_Validating);
            // 
            // lbFrom
            // 
            this.lbFrom.Location = new System.Drawing.Point(21, 25);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(87, 16);
            this.lbFrom.TabIndex = 2;
            this.lbFrom.Text = "From Address";
            this.lbFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDisplay
            // 
            this.lbDisplay.Location = new System.Drawing.Point(21, 53);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(87, 16);
            this.lbDisplay.TabIndex = 4;
            this.lbDisplay.Text = "Display Name";
            this.lbDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkUseSSL
            // 
            this.chkUseSSL.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tblSenderBindingSource, "UseSSL", true));
            this.chkUseSSL.Location = new System.Drawing.Point(113, 135);
            this.chkUseSSL.Name = "chkUseSSL";
            this.chkUseSSL.Size = new System.Drawing.Size(168, 20);
            this.chkUseSSL.TabIndex = 31;
            this.chkUseSSL.Text = "Use SSL";
            this.chkUseSSL.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            this.txtDisplay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSenderBindingSource, "DisplayName", true));
            this.txtDisplay.Location = new System.Drawing.Point(116, 49);
            this.txtDisplay.MaxLength = 50;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(151, 23);
            this.txtDisplay.TabIndex = 1;
            // 
            // lbReplay
            // 
            this.lbReplay.Location = new System.Drawing.Point(21, 80);
            this.lbReplay.Name = "lbReplay";
            this.lbReplay.Size = new System.Drawing.Size(87, 16);
            this.lbReplay.TabIndex = 6;
            this.lbReplay.Text = "Replay To";
            this.lbReplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplay
            // 
            this.txtReplay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSenderBindingSource, "ReplayTo", true));
            this.txtReplay.Location = new System.Drawing.Point(116, 77);
            this.txtReplay.MaxLength = 50;
            this.txtReplay.Name = "txtReplay";
            this.txtReplay.Size = new System.Drawing.Size(151, 23);
            this.txtReplay.TabIndex = 2;
            // 
            // cmbPriority
            // 
            this.cmbPriority.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.tblSenderBindingSource, "Priority", true));
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(360, 21);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(79, 24);
            this.cmbPriority.TabIndex = 3;
            // 
            // lbPriority
            // 
            this.lbPriority.Location = new System.Drawing.Point(273, 25);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(85, 16);
            this.lbPriority.TabIndex = 10;
            this.lbPriority.Text = "Priority";
            this.lbPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkDelivery
            // 
            this.chkDelivery.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tblSenderBindingSource, "DeliveryNotification", true));
            this.chkDelivery.Location = new System.Drawing.Point(114, 109);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(168, 20);
            this.chkDelivery.TabIndex = 8;
            this.chkDelivery.Text = "Request Delivery Receipt";
            this.chkDelivery.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbSMTP);
            this.groupBox4.Controls.Add(this.txtServer);
            this.groupBox4.Controls.Add(this.txtPort);
            this.groupBox4.Controls.Add(this.lbUser);
            this.groupBox4.Controls.Add(this.lbPort);
            this.groupBox4.Controls.Add(this.txtUserName);
            this.groupBox4.Controls.Add(this.lbSleepunit);
            this.groupBox4.Controls.Add(this.lbPw);
            this.groupBox4.Controls.Add(this.txtSleepInterval);
            this.groupBox4.Controls.Add(this.txtPassword);
            this.groupBox4.Controls.Add(this.lbSleep);
            this.groupBox4.Location = new System.Drawing.Point(9, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 131);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Server Setting";
            // 
            // lbSMTP
            // 
            this.lbSMTP.Location = new System.Drawing.Point(6, 17);
            this.lbSMTP.Name = "lbSMTP";
            this.lbSMTP.Size = new System.Drawing.Size(87, 16);
            this.lbSMTP.TabIndex = 12;
            this.lbSMTP.Text = "SMTP Server";
            this.lbSMTP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServer
            // 
            this.txtServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSenderBindingSource, "SMTP_Server", true));
            this.txtServer.Location = new System.Drawing.Point(100, 14);
            this.txtServer.MaxLength = 50;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(324, 23);
            this.txtServer.TabIndex = 0;
            this.txtServer.Validated += new System.EventHandler(this.udfValidated);
            this.txtServer.Validating += new System.ComponentModel.CancelEventHandler(this.txtServer_Validating);
            // 
            // txtPort
            // 
            // 
            // 
            // 
            this.txtPort.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPort.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtPort.DataBindings.Add(new System.Windows.Forms.Binding("ValueObject", this.tblSenderBindingSource, "ServerPort", true));
            this.txtPort.Location = new System.Drawing.Point(342, 64);
            this.txtPort.MinValue = 0;
            this.txtPort.Name = "txtPort";
            this.txtPort.ShowUpDown = true;
            this.txtPort.Size = new System.Drawing.Size(82, 23);
            this.txtPort.TabIndex = 2;
            this.txtPort.Value = 25;
            // 
            // lbUser
            // 
            this.lbUser.Location = new System.Drawing.Point(6, 47);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(87, 16);
            this.lbUser.TabIndex = 14;
            this.lbUser.Text = "User Name";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPort
            // 
            this.lbPort.Location = new System.Drawing.Point(263, 68);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(73, 16);
            this.lbPort.TabIndex = 18;
            this.lbPort.Text = "Server Port";
            this.lbPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUserName
            // 
            this.txtUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSenderBindingSource, "UserName", true));
            this.txtUserName.Location = new System.Drawing.Point(100, 43);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(151, 23);
            this.txtUserName.TabIndex = 15;
            // 
            // lbSleepunit
            // 
            this.lbSleepunit.AutoSize = true;
            this.lbSleepunit.Location = new System.Drawing.Point(155, 103);
            this.lbSleepunit.Name = "lbSleepunit";
            this.lbSleepunit.Size = new System.Drawing.Size(50, 16);
            this.lbSleepunit.TabIndex = 23;
            this.lbSleepunit.Text = "Second";
            // 
            // lbPw
            // 
            this.lbPw.Location = new System.Drawing.Point(6, 72);
            this.lbPw.Name = "lbPw";
            this.lbPw.Size = new System.Drawing.Size(87, 16);
            this.lbPw.TabIndex = 16;
            this.lbPw.Text = "Password";
            this.lbPw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSleepInterval
            // 
            // 
            // 
            // 
            this.txtSleepInterval.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSleepInterval.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtSleepInterval.DataBindings.Add(new System.Windows.Forms.Binding("ValueObject", this.tblSenderBindingSource, "SleepInterval", true));
            this.txtSleepInterval.Location = new System.Drawing.Point(100, 99);
            this.txtSleepInterval.MinValue = 3;
            this.txtSleepInterval.Name = "txtSleepInterval";
            this.txtSleepInterval.ShowUpDown = true;
            this.txtSleepInterval.Size = new System.Drawing.Size(49, 23);
            this.txtSleepInterval.TabIndex = 22;
            this.txtSleepInterval.Value = 30;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSenderBindingSource, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(100, 68);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(151, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // lbSleep
            // 
            this.lbSleep.Location = new System.Drawing.Point(6, 103);
            this.lbSleep.Name = "lbSleep";
            this.lbSleep.Size = new System.Drawing.Size(87, 16);
            this.lbSleep.TabIndex = 21;
            this.lbSleep.Text = "Sleep Interval";
            this.lbSleep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblSenderTableAdapter
            // 
            this.tblSenderTableAdapter.ClearBeforeFill = true;
            // 
            // iErr
            // 
            this.iErr.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MMG_Soft_MailSender.Properties.Resources._1309075416_download;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbSender
            // 
            this.lbSender.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbSender.Location = new System.Drawing.Point(73, -3);
            this.lbSender.Name = "lbSender";
            this.lbSender.Size = new System.Drawing.Size(348, 70);
            this.lbSender.TabIndex = 4;
            this.lbSender.Text = "Sender";
            // 
            // SenderProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbSender);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "SenderProfile";
            this.Size = new System.Drawing.Size(692, 503);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblSenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSleepInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iErr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProfile;
        private System.Windows.Forms.Label lbProfile;
        private System.Windows.Forms.BindingSource tblSenderBindingSource;
        private ds ds;
        private MMG_Soft_MailSender.dsTableAdapters.tblSenderTableAdapter tblSenderTableAdapter;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.TextBox txtReplay;
        private System.Windows.Forms.Label lbReplay;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lbDisplay;
        private cmbPriority cmbPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Label lbSMTP;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPw;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbSleepunit;
        private DevComponents.Editors.IntegerInput txtSleepInterval;
        private System.Windows.Forms.Label lbSleep;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider iErr;
        private System.Windows.Forms.CheckBox chkUseSSL;
        private DevComponents.Editors.IntegerInput txtPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lbSender;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolTip iToolTip;
    }
}
