namespace MMG_Soft_MailSender.UserCtrl
{
    partial class Recipients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipients));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.btnTextImport = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDeleteItems = new System.Windows.Forms.Button();
            this.btnMarkasBlocked = new System.Windows.Forms.Button();
            this.btnMarkAsUnSend = new System.Windows.Forms.Button();
            this.btnMarkAsSend = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.tblRecipientsItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new MMG_Soft_MailSender.ds();
            this.cmbProfile = new System.Windows.Forms.ComboBox();
            this.tblRecipientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbProfile = new System.Windows.Forms.Label();
            this.tblRecipientsTableAdapter = new MMG_Soft_MailSender.dsTableAdapters.tblRecipientsTableAdapter();
            this.tblRecipientsItemsTableAdapter = new MMG_Soft_MailSender.dsTableAdapters.tblRecipientsItemsTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbReceipients = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.iToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clmStatus = new EasyInfoSearch.Class.DataGridViewImageValueColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecipientsItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecipientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtHelp);
            this.groupBox1.Controls.Add(this.btnTextImport);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.btnDeleteItems);
            this.groupBox1.Controls.Add(this.btnMarkasBlocked);
            this.groupBox1.Controls.Add(this.btnMarkAsUnSend);
            this.groupBox1.Controls.Add(this.btnMarkAsSend);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.dtgData);
            this.groupBox1.Controls.Add(this.cmbProfile);
            this.groupBox1.Controls.Add(this.lbProfile);
            this.groupBox1.Location = new System.Drawing.Point(0, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHelp.BackColor = System.Drawing.Color.White;
            this.txtHelp.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtHelp.Location = new System.Drawing.Point(557, 49);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHelp.Size = new System.Drawing.Size(131, 310);
            this.txtHelp.TabIndex = 46;
            this.txtHelp.TabStop = false;
            this.txtHelp.Text = resources.GetString("txtHelp.Text");
            // 
            // btnTextImport
            // 
            this.btnTextImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTextImport.Image = global::MMG_Soft_MailSender.Properties.Resources._1309667678_text_enriched;
            this.btnTextImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextImport.Location = new System.Drawing.Point(82, 333);
            this.btnTextImport.Name = "btnTextImport";
            this.btnTextImport.Size = new System.Drawing.Size(70, 29);
            this.btnTextImport.TabIndex = 8;
            this.btnTextImport.Text = "Text";
            this.btnTextImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTextImport.UseVisualStyleBackColor = true;
            this.btnTextImport.Click += new System.EventHandler(this.btnTextImport_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::MMG_Soft_MailSender.Properties.Resources._1309237517_netvibes;
            this.btnInsert.Location = new System.Drawing.Point(521, 49);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(30, 29);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.Image = global::MMG_Soft_MailSender.Properties.Resources._1309236473_Close;
            this.btnDeleteItems.Location = new System.Drawing.Point(521, 78);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.Size = new System.Drawing.Size(30, 29);
            this.btnDeleteItems.TabIndex = 6;
            this.btnDeleteItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteItems.UseVisualStyleBackColor = true;
            this.btnDeleteItems.Click += new System.EventHandler(this.btnDeleteItems_Click);
            // 
            // btnMarkasBlocked
            // 
            this.btnMarkasBlocked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMarkasBlocked.Image = global::MMG_Soft_MailSender.Properties.Resources.Blocked;
            this.btnMarkasBlocked.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkasBlocked.Location = new System.Drawing.Point(396, 334);
            this.btnMarkasBlocked.Name = "btnMarkasBlocked";
            this.btnMarkasBlocked.Size = new System.Drawing.Size(125, 29);
            this.btnMarkasBlocked.TabIndex = 11;
            this.btnMarkasBlocked.Text = "Mark as Blocked";
            this.btnMarkasBlocked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarkasBlocked.UseVisualStyleBackColor = true;
            this.btnMarkasBlocked.Click += new System.EventHandler(this.btnMarkasBlocked_Click);
            // 
            // btnMarkAsUnSend
            // 
            this.btnMarkAsUnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMarkAsUnSend.Image = global::MMG_Soft_MailSender.Properties.Resources.mail_new;
            this.btnMarkAsUnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkAsUnSend.Location = new System.Drawing.Point(161, 334);
            this.btnMarkAsUnSend.Name = "btnMarkAsUnSend";
            this.btnMarkAsUnSend.Size = new System.Drawing.Size(125, 29);
            this.btnMarkAsUnSend.TabIndex = 9;
            this.btnMarkAsUnSend.Text = "Mark as UnSend";
            this.btnMarkAsUnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarkAsUnSend.UseVisualStyleBackColor = true;
            this.btnMarkAsUnSend.Click += new System.EventHandler(this.tnMakeUnSend_Click);
            // 
            // btnMarkAsSend
            // 
            this.btnMarkAsSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMarkAsSend.Image = global::MMG_Soft_MailSender.Properties.Resources.mail_send;
            this.btnMarkAsSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkAsSend.Location = new System.Drawing.Point(286, 334);
            this.btnMarkAsSend.Name = "btnMarkAsSend";
            this.btnMarkAsSend.Size = new System.Drawing.Size(110, 29);
            this.btnMarkAsSend.TabIndex = 10;
            this.btnMarkAsSend.Text = "Mark as Send";
            this.btnMarkAsSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarkAsSend.UseVisualStyleBackColor = true;
            this.btnMarkAsSend.Click += new System.EventHandler(this.btnMakeSend_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImport.Image = global::MMG_Soft_MailSender.Properties.Resources._1308985619_page_white_excel;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(8, 333);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(70, 29);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Excel";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::MMG_Soft_MailSender.Properties.Resources._1308978920_001_01;
            this.btnNew.Location = new System.Drawing.Point(453, 17);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(33, 29);
            this.btnNew.TabIndex = 3;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(420, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(33, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(387, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(33, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtgData
            // 
            this.dtgData.AllowUserToAddRows = false;
            this.dtgData.AllowUserToDeleteRows = false;
            this.dtgData.AllowUserToResizeRows = false;
            this.dtgData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgData.AutoGenerateColumns = false;
            this.dtgData.BackgroundColor = System.Drawing.Color.White;
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStatus,
            this.clmID,
            this.clmEmailAddress,
            this.recipientsIDDataGridViewTextBoxColumn});
            this.dtgData.DataSource = this.tblRecipientsItemsBindingSource;
            this.dtgData.Location = new System.Drawing.Point(9, 51);
            this.dtgData.Name = "dtgData";
            this.dtgData.RowHeadersVisible = false;
            this.dtgData.RowHeadersWidth = 50;
            this.dtgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgData.Size = new System.Drawing.Size(510, 279);
            this.dtgData.TabIndex = 4;
            // 
            // tblRecipientsItemsBindingSource
            // 
            this.tblRecipientsItemsBindingSource.DataMember = "tblRecipientsItems";
            this.tblRecipientsItemsBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbProfile
            // 
            this.cmbProfile.DataSource = this.tblRecipientsBindingSource;
            this.cmbProfile.DisplayMember = "ProfileName";
            this.cmbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbProfile.FormattingEnabled = true;
            this.cmbProfile.Location = new System.Drawing.Point(58, 18);
            this.cmbProfile.Name = "cmbProfile";
            this.cmbProfile.Size = new System.Drawing.Size(323, 27);
            this.cmbProfile.TabIndex = 0;
            this.cmbProfile.ValueMember = "ID";
            this.cmbProfile.SelectedIndexChanged += new System.EventHandler(this.cmbProfile_SelectedIndexChanged);
            // 
            // tblRecipientsBindingSource
            // 
            this.tblRecipientsBindingSource.DataMember = "tblRecipients";
            this.tblRecipientsBindingSource.DataSource = this.ds;
            // 
            // lbProfile
            // 
            this.lbProfile.Location = new System.Drawing.Point(6, 23);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(44, 16);
            this.lbProfile.TabIndex = 2;
            this.lbProfile.Text = "Profile";
            this.lbProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblRecipientsTableAdapter
            // 
            this.tblRecipientsTableAdapter.ClearBeforeFill = true;
            // 
            // tblRecipientsItemsTableAdapter
            // 
            this.tblRecipientsItemsTableAdapter.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1308997386_Unread Mail Alt.png");
            this.imageList1.Images.SetKeyName(1, "1308997521_Forward.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MMG_Soft_MailSender.Properties.Resources._1309075310_address_book;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbReceipients
            // 
            this.lbReceipients.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbReceipients.Location = new System.Drawing.Point(73, 2);
            this.lbReceipients.Name = "lbReceipients";
            this.lbReceipients.Size = new System.Drawing.Size(448, 70);
            this.lbReceipients.TabIndex = 4;
            this.lbReceipients.Text = "Receipients";
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.Width = 40;
            // 
            // clmID
            // 
            this.clmID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            this.clmID.Width = 45;
            // 
            // clmEmailAddress
            // 
            this.clmEmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmEmailAddress.DataPropertyName = "EmailAddress";
            this.clmEmailAddress.HeaderText = "EmailAddress";
            this.clmEmailAddress.Name = "clmEmailAddress";
            this.clmEmailAddress.ReadOnly = true;
            // 
            // recipientsIDDataGridViewTextBoxColumn
            // 
            this.recipientsIDDataGridViewTextBoxColumn.DataPropertyName = "RecipientsID";
            this.recipientsIDDataGridViewTextBoxColumn.HeaderText = "RecipientsID";
            this.recipientsIDDataGridViewTextBoxColumn.Name = "recipientsIDDataGridViewTextBoxColumn";
            this.recipientsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recipientsIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Recipients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbReceipients);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Recipients";
            this.Size = new System.Drawing.Size(702, 434);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecipientsItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecipientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.ComboBox cmbProfile;
        private System.Windows.Forms.Label lbProfile;
        private System.Windows.Forms.BindingSource tblRecipientsItemsBindingSource;
        private ds ds;
        private System.Windows.Forms.BindingSource tblRecipientsBindingSource;
        private MMG_Soft_MailSender.dsTableAdapters.tblRecipientsTableAdapter tblRecipientsTableAdapter;
        private MMG_Soft_MailSender.dsTableAdapters.tblRecipientsItemsTableAdapter tblRecipientsItemsTableAdapter;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lbReceipients;
        private System.Windows.Forms.Button btnMarkasBlocked;
        private System.Windows.Forms.Button btnMarkAsUnSend;
        private System.Windows.Forms.Button btnMarkAsSend;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnDeleteItems;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnTextImport;
        private System.Windows.Forms.ToolTip iToolTip;
        private System.Windows.Forms.TextBox txtHelp;
        private EasyInfoSearch.Class.DataGridViewImageValueColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientsIDDataGridViewTextBoxColumn;
    }
}
