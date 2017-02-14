namespace MMG_Soft_MailSender.UserCtrl
{
    partial class Content
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Content));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.tblContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new MMG_Soft_MailSender.ds();
            this.lbSubject = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkIsHtml = new System.Windows.Forms.CheckBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbProfile = new System.Windows.Forms.ComboBox();
            this.lbProfile = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.iOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tblContentTableAdapter = new MMG_Soft_MailSender.dsTableAdapters.tblContentTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbContent = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.iToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtHelp);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.lbSubject);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.chkIsHtml);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.cmbProfile);
            this.groupBox1.Controls.Add(this.lbProfile);
            this.groupBox1.Controls.Add(this.txtBody);
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHelp.BackColor = System.Drawing.Color.White;
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtHelp.Location = new System.Drawing.Point(544, 81);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHelp.Size = new System.Drawing.Size(137, 224);
            this.txtHelp.TabIndex = 46;
            this.txtHelp.TabStop = false;
            this.txtHelp.Text = resources.GetString("txtHelp.Text");
            // 
            // txtSubject
            // 
            this.txtSubject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContentBindingSource, "Subject", true));
            this.txtSubject.Location = new System.Drawing.Point(127, 55);
            this.txtSubject.MaxLength = 255;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(372, 22);
            this.txtSubject.TabIndex = 4;
            // 
            // tblContentBindingSource
            // 
            this.tblContentBindingSource.DataMember = "tblContent";
            this.tblContentBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(72, 60);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(49, 14);
            this.lbSubject.TabIndex = 44;
            this.lbSubject.Text = "Subject";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::MMG_Soft_MailSender.Properties.Resources._1308979161_disk;
            this.btnSave.Location = new System.Drawing.Point(505, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(33, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkIsHtml
            // 
            this.chkIsHtml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkIsHtml.AutoSize = true;
            this.chkIsHtml.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tblContentBindingSource, "isHtml", true));
            this.chkIsHtml.Location = new System.Drawing.Point(71, 285);
            this.chkIsHtml.Name = "chkIsHtml";
            this.chkIsHtml.Size = new System.Drawing.Size(58, 18);
            this.chkIsHtml.TabIndex = 7;
            this.chkIsHtml.Text = "isHtml";
            this.chkIsHtml.UseVisualStyleBackColor = true;
            this.chkIsHtml.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::MMG_Soft_MailSender.Properties.Resources._1308978920_001_01;
            this.btnNew.Location = new System.Drawing.Point(466, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(33, 29);
            this.btnNew.TabIndex = 3;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(433, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(33, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(400, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(33, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbProfile
            // 
            this.cmbProfile.DataSource = this.tblContentBindingSource;
            this.cmbProfile.DisplayMember = "ProfileName";
            this.cmbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbProfile.FormattingEnabled = true;
            this.cmbProfile.Location = new System.Drawing.Point(71, 21);
            this.cmbProfile.Name = "cmbProfile";
            this.cmbProfile.Size = new System.Drawing.Size(323, 27);
            this.cmbProfile.TabIndex = 0;
            this.cmbProfile.ValueMember = "ID";
            this.cmbProfile.SelectedIndexChanged += new System.EventHandler(this.cmbProfile_SelectedIndexChanged);
            // 
            // lbProfile
            // 
            this.lbProfile.AutoSize = true;
            this.lbProfile.Location = new System.Drawing.Point(19, 27);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(40, 14);
            this.lbProfile.TabIndex = 35;
            this.lbProfile.Text = "Profile";
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBody.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblContentBindingSource, "Body", true));
            this.txtBody.Location = new System.Drawing.Point(71, 81);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(428, 198);
            this.txtBody.TabIndex = 5;
            this.txtBody.Text = "";
            // 
            // iOpenFileDialog
            // 
            this.iOpenFileDialog.FileName = "Open Htm file";
            this.iOpenFileDialog.Filter = "Html|*html|htm|*.htm";
            // 
            // tblContentTableAdapter
            // 
            this.tblContentTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MMG_Soft_MailSender.Properties.Resources._1309075338_edit_notes;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbContent
            // 
            this.lbContent.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbContent.Location = new System.Drawing.Point(73, 3);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(341, 70);
            this.lbContent.TabIndex = 3;
            this.lbContent.Text = "Content";
            // 
            // Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Content";
            this.Size = new System.Drawing.Size(690, 383);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblContentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog iOpenFileDialog;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbProfile;
        private System.Windows.Forms.Label lbProfile;
        private System.Windows.Forms.BindingSource tblContentBindingSource;
        private ds ds;
        private MMG_Soft_MailSender.dsTableAdapters.tblContentTableAdapter tblContentTableAdapter;
        private System.Windows.Forms.CheckBox chkIsHtml;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lbContent;
        private System.Windows.Forms.ToolTip iToolTip;
        private System.Windows.Forms.TextBox txtHelp;
    }
}
