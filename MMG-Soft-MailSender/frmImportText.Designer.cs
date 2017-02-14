namespace MMG_Soft_MailSender
{
    partial class frmImportText
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lbFile = new System.Windows.Forms.Label();
            this.chkNewLine = new System.Windows.Forms.CheckBox();
            this.txtSplit = new System.Windows.Forms.TextBox();
            this.lbSplit = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.iOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.White;
            this.txtPath.Location = new System.Drawing.Point(94, 19);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(306, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::MMG_Soft_MailSender.Properties.Resources._1308986488_folder_horizontal_open;
            this.btnOpen.Location = new System.Drawing.Point(406, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(33, 25);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lbFile
            // 
            this.lbFile.Location = new System.Drawing.Point(12, 21);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(76, 19);
            this.lbFile.TabIndex = 2;
            this.lbFile.Text = "Text File";
            this.lbFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkNewLine
            // 
            this.chkNewLine.AutoSize = true;
            this.chkNewLine.Location = new System.Drawing.Point(130, 54);
            this.chkNewLine.Name = "chkNewLine";
            this.chkNewLine.Size = new System.Drawing.Size(80, 18);
            this.chkNewLine.TabIndex = 3;
            this.chkNewLine.Text = "Enter Key";
            this.chkNewLine.UseVisualStyleBackColor = true;
            this.chkNewLine.CheckedChanged += new System.EventHandler(this.chkNewLine_CheckedChanged);
            // 
            // txtSplit
            // 
            this.txtSplit.Location = new System.Drawing.Point(94, 52);
            this.txtSplit.MaxLength = 1;
            this.txtSplit.Name = "txtSplit";
            this.txtSplit.Size = new System.Drawing.Size(30, 22);
            this.txtSplit.TabIndex = 4;
            this.txtSplit.Text = ",";
            // 
            // lbSplit
            // 
            this.lbSplit.Location = new System.Drawing.Point(12, 53);
            this.lbSplit.Name = "lbSplit";
            this.lbSplit.Size = new System.Drawing.Size(76, 19);
            this.lbSplit.TabIndex = 5;
            this.lbSplit.Text = "Split By";
            this.lbSplit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            this.btnReturn.Image = global::MMG_Soft_MailSender.Properties.Resources._1308980468_001_39;
            this.btnReturn.Location = new System.Drawing.Point(400, 69);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(44, 32);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Image = global::MMG_Soft_MailSender.Properties.Resources._1308980425_001_06;
            this.btnOk.Location = new System.Drawing.Point(356, 69);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(44, 32);
            this.btnOk.TabIndex = 7;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // iOpenFileDialog
            // 
            this.iOpenFileDialog.FileName = "Open Text file";
            this.iOpenFileDialog.Filter = "Text File|*.txt";
            // 
            // frmImportText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 108);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lbSplit);
            this.Controls.Add(this.txtSplit);
            this.Controls.Add(this.chkNewLine);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmImportText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Text File";
            this.Load += new System.EventHandler(this.frmImportText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.CheckBox chkNewLine;
        private System.Windows.Forms.TextBox txtSplit;
        private System.Windows.Forms.Label lbSplit;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.OpenFileDialog iOpenFileDialog;
        
    }
}