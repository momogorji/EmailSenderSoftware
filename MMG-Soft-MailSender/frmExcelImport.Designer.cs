namespace MMG_Soft_MailSender
{
    partial class frmExcelImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcelImport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Wizard1 = new DevComponents.DotNetBar.Wizard();
            this.wpFileSelect = new DevComponents.DotNetBar.WizardPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lbProfile = new System.Windows.Forms.Label();
            this.wpSheet = new DevComponents.DotNetBar.WizardPage();
            this.lbSelectSheet = new System.Windows.Forms.Label();
            this.lstSheet = new System.Windows.Forms.ListBox();
            this.wpPreviwe = new DevComponents.DotNetBar.WizardPage();
            this.txtEmail = new DevComponents.Editors.IntegerInput();
            this.lbEmailClm = new System.Windows.Forms.Label();
            this.txtImportFromLine = new DevComponents.Editors.IntegerInput();
            this.lbImpline = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wpFinish = new DevComponents.DotNetBar.WizardPage();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.lbstatus = new System.Windows.Forms.Label();
            this.Wizard1.SuspendLayout();
            this.wpFileSelect.SuspendLayout();
            this.wpSheet.SuspendLayout();
            this.wpPreviwe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportFromLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.wpFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // iOpenFileDialog
            // 
            this.iOpenFileDialog.FileName = "Excel Import";
            this.iOpenFileDialog.Filter = "Excel|*.xls|Excel2007|*.xlsx";
            // 
            // Wizard1
            // 
            this.Wizard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(229)))), ((int)(((byte)(253)))));
            this.Wizard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Wizard1.BackgroundImage")));
            this.Wizard1.ButtonStyle = DevComponents.DotNetBar.eWizardStyle.Office2007;
            this.Wizard1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Wizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wizard1.FinishButtonTabIndex = 3;
            this.Wizard1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.Wizard1.FooterStyle.BackColor = System.Drawing.Color.Transparent;
            this.Wizard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(57)))), ((int)(((byte)(129)))));
            this.Wizard1.HeaderCaptionFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Wizard1.HeaderDescriptionIndent = 60;
            this.Wizard1.HeaderDescriptionVisible = false;
            this.Wizard1.HeaderHeight = 80;
            this.Wizard1.HeaderImageAlignment = DevComponents.DotNetBar.eWizardTitleImageAlignment.Left;
            // 
            // 
            // 
            this.Wizard1.HeaderStyle.BackColor = System.Drawing.Color.Transparent;
            this.Wizard1.HeaderStyle.BackColorGradientAngle = 90;
            this.Wizard1.HeaderStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Wizard1.HeaderStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(157)))), ((int)(((byte)(182)))));
            this.Wizard1.HeaderStyle.BorderBottomWidth = 1;
            this.Wizard1.HeaderStyle.BorderColor = System.Drawing.SystemColors.Control;
            this.Wizard1.HeaderStyle.BorderLeftWidth = 1;
            this.Wizard1.HeaderStyle.BorderRightWidth = 1;
            this.Wizard1.HeaderStyle.BorderTopWidth = 1;
            this.Wizard1.HeaderStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Wizard1.HeaderStyle.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Wizard1.HeaderTitleIndent = 62;
            this.Wizard1.HelpButtonVisible = false;
            this.Wizard1.Location = new System.Drawing.Point(0, 0);
            this.Wizard1.Name = "Wizard1";
            this.Wizard1.Size = new System.Drawing.Size(538, 403);
            this.Wizard1.TabIndex = 2;
            this.Wizard1.WizardPages.AddRange(new DevComponents.DotNetBar.WizardPage[] {
            this.wpFileSelect,
            this.wpSheet,
            this.wpPreviwe,
            this.wpFinish});
            this.Wizard1.WizardPageChanging += new DevComponents.DotNetBar.WizardCancelPageChangeEventHandler(this.Wizard1_WizardPageChanging);
            this.Wizard1.FinishButtonClick += new System.ComponentModel.CancelEventHandler(this.Wizard1_FinishButtonClick);
            // 
            // wpFileSelect
            // 
            this.wpFileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wpFileSelect.AntiAlias = false;
            this.wpFileSelect.BackColor = System.Drawing.Color.Transparent;
            this.wpFileSelect.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.wpFileSelect.Controls.Add(this.btnEdit);
            this.wpFileSelect.Controls.Add(this.txtFile);
            this.wpFileSelect.Controls.Add(this.lbProfile);
            this.wpFileSelect.Location = new System.Drawing.Point(7, 92);
            this.wpFileSelect.Name = "wpFileSelect";
            this.wpFileSelect.PageDescription = "Select Excel File To Continue";
            this.wpFileSelect.PageHeaderImage = global::MMG_Soft_MailSender.Properties.Resources._1308986224_Arzo_Icons_Icon_96_2;
            this.wpFileSelect.PageTitle = "Excel Email File";
            this.wpFileSelect.Size = new System.Drawing.Size(524, 253);
            this.wpFileSelect.TabIndex = 13;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::MMG_Soft_MailSender.Properties.Resources._1308986488_folder_horizontal_open;
            this.btnEdit.Location = new System.Drawing.Point(484, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 21);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(91, 0);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(387, 21);
            this.txtFile.TabIndex = 4;
            // 
            // lbProfile
            // 
            this.lbProfile.AutoSize = true;
            this.lbProfile.Location = new System.Drawing.Point(30, 4);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(55, 13);
            this.lbProfile.TabIndex = 3;
            this.lbProfile.Text = "Select File";
            // 
            // wpSheet
            // 
            this.wpSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wpSheet.AntiAlias = false;
            this.wpSheet.BackColor = System.Drawing.Color.Transparent;
            this.wpSheet.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.wpSheet.Controls.Add(this.lbSelectSheet);
            this.wpSheet.Controls.Add(this.lstSheet);
            this.wpSheet.Location = new System.Drawing.Point(7, 92);
            this.wpSheet.Name = "wpSheet";
            this.wpSheet.PageDescription = " Please select as sheet to import from";
            this.wpSheet.PageHeaderImage = global::MMG_Soft_MailSender.Properties.Resources._1308986224_Arzo_Icons_Icon_96_2;
            this.wpSheet.PageTitle = "Select Sheet";
            this.wpSheet.Size = new System.Drawing.Size(524, 253);
            this.wpSheet.TabIndex = 14;
            this.wpSheet.AfterPageDisplayed += new DevComponents.DotNetBar.WizardPageChangeEventHandler(this.wpSheet_AfterPageDisplayed);
            // 
            // lbSelectSheet
            // 
            this.lbSelectSheet.AutoSize = true;
            this.lbSelectSheet.Location = new System.Drawing.Point(15, 0);
            this.lbSelectSheet.Name = "lbSelectSheet";
            this.lbSelectSheet.Size = new System.Drawing.Size(79, 13);
            this.lbSelectSheet.TabIndex = 4;
            this.lbSelectSheet.Text = "Select a sheet:";
            // 
            // lstSheet
            // 
            this.lstSheet.FormattingEnabled = true;
            this.lstSheet.Location = new System.Drawing.Point(18, 18);
            this.lstSheet.Name = "lstSheet";
            this.lstSheet.Size = new System.Drawing.Size(263, 69);
            this.lstSheet.TabIndex = 1;
            // 
            // wpPreviwe
            // 
            this.wpPreviwe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wpPreviwe.BackColor = System.Drawing.Color.Transparent;
            this.wpPreviwe.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.wpPreviwe.Controls.Add(this.txtEmail);
            this.wpPreviwe.Controls.Add(this.lbEmailClm);
            this.wpPreviwe.Controls.Add(this.txtImportFromLine);
            this.wpPreviwe.Controls.Add(this.lbImpline);
            this.wpPreviwe.Controls.Add(this.dataGridView1);
            this.wpPreviwe.Location = new System.Drawing.Point(7, 92);
            this.wpPreviwe.Name = "wpPreviwe";
            this.wpPreviwe.PageDescription = "Data Preview";
            this.wpPreviwe.PageHeaderImage = global::MMG_Soft_MailSender.Properties.Resources._1308986224_Arzo_Icons_Icon_96_2;
            this.wpPreviwe.PageTitle = "Preview";
            this.wpPreviwe.Size = new System.Drawing.Size(524, 253);
            this.wpPreviwe.TabIndex = 15;
            this.wpPreviwe.Text = "wizardPage1";
            this.wpPreviwe.AfterPageDisplayed += new DevComponents.DotNetBar.WizardPageChangeEventHandler(this.wpPreviwe_AfterPageDisplayed);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtEmail.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtEmail.Location = new System.Drawing.Point(239, 17);
            this.txtEmail.MinValue = 1;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShowUpDown = true;
            this.txtEmail.Size = new System.Drawing.Size(43, 21);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Value = 1;
            // 
            // lbEmailClm
            // 
            this.lbEmailClm.AutoSize = true;
            this.lbEmailClm.Location = new System.Drawing.Point(166, 21);
            this.lbEmailClm.Name = "lbEmailClm";
            this.lbEmailClm.Size = new System.Drawing.Size(69, 13);
            this.lbEmailClm.TabIndex = 7;
            this.lbEmailClm.Text = "Email Column";
            // 
            // txtImportFromLine
            // 
            // 
            // 
            // 
            this.txtImportFromLine.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtImportFromLine.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtImportFromLine.Location = new System.Drawing.Point(92, 17);
            this.txtImportFromLine.MinValue = 1;
            this.txtImportFromLine.Name = "txtImportFromLine";
            this.txtImportFromLine.ShowUpDown = true;
            this.txtImportFromLine.Size = new System.Drawing.Size(43, 21);
            this.txtImportFromLine.TabIndex = 3;
            this.txtImportFromLine.Value = 1;
            // 
            // lbImpline
            // 
            this.lbImpline.AutoSize = true;
            this.lbImpline.Location = new System.Drawing.Point(3, 21);
            this.lbImpline.Name = "lbImpline";
            this.lbImpline.Size = new System.Drawing.Size(83, 13);
            this.lbImpline.TabIndex = 6;
            this.lbImpline.Text = "Import from line";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 55;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(524, 209);
            this.dataGridView1.TabIndex = 5;
            // 
            // wpFinish
            // 
            this.wpFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wpFinish.AntiAlias = false;
            this.wpFinish.BackColor = System.Drawing.Color.Transparent;
            this.wpFinish.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.wpFinish.Controls.Add(this.progressBarX1);
            this.wpFinish.Controls.Add(this.lbstatus);
            this.wpFinish.InteriorPage = false;
            this.wpFinish.Location = new System.Drawing.Point(0, 0);
            this.wpFinish.Name = "wpFinish";
            this.wpFinish.Size = new System.Drawing.Size(538, 357);
            this.wpFinish.TabIndex = 12;
            // 
            // progressBarX1
            // 
            this.progressBarX1.Location = new System.Drawing.Point(47, 131);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(427, 23);
            this.progressBarX1.TabIndex = 6;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // lbstatus
            // 
            this.lbstatus.BackColor = System.Drawing.Color.Transparent;
            this.lbstatus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Location = new System.Drawing.Point(44, 110);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(430, 18);
            this.lbstatus.TabIndex = 4;
            this.lbstatus.Text = "To Imort Date to Databasae Click Finish";
            // 
            // frmExcelImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 403);
            this.Controls.Add(this.Wizard1);
            this.Name = "frmExcelImport";
            this.Text = "Excel Import";
            this.Load += new System.EventHandler(this.frmExcelImport_Load);
            this.Wizard1.ResumeLayout(false);
            this.wpFileSelect.ResumeLayout(false);
            this.wpFileSelect.PerformLayout();
            this.wpSheet.ResumeLayout(false);
            this.wpSheet.PerformLayout();
            this.wpPreviwe.ResumeLayout(false);
            this.wpPreviwe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImportFromLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.wpFinish.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal DevComponents.DotNetBar.Wizard Wizard1;
        internal DevComponents.DotNetBar.WizardPage wpFinish;
        internal System.Windows.Forms.Label lbstatus;
        private DevComponents.DotNetBar.WizardPage wpFileSelect;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lbProfile;
        private System.Windows.Forms.Button btnEdit;
        private DevComponents.DotNetBar.WizardPage wpSheet;
        private System.Windows.Forms.Label lbSelectSheet;
        private System.Windows.Forms.ListBox lstSheet;
        private System.Windows.Forms.OpenFileDialog iOpenFileDialog;
        private DevComponents.DotNetBar.WizardPage wpPreviwe;
        private System.Windows.Forms.Label lbImpline;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.Editors.IntegerInput txtImportFromLine;
        private System.Windows.Forms.Label lbEmailClm;
        private DevComponents.Editors.IntegerInput txtEmail;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;

    }
}