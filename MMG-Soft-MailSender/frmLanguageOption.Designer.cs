namespace MMG_Soft_MailSender
{
    partial class frmLanguageOption
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
            this.lstLanguage = new System.Windows.Forms.ListBox();
            this.btnAccep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLanguage
            // 
            this.lstLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstLanguage.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lstLanguage.FormattingEnabled = true;
            this.lstLanguage.ItemHeight = 25;
            this.lstLanguage.Location = new System.Drawing.Point(0, 0);
            this.lstLanguage.Name = "lstLanguage";
            this.lstLanguage.Size = new System.Drawing.Size(224, 154);
            this.lstLanguage.TabIndex = 0;
            // 
            // btnAccep
            // 
            this.btnAccep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAccep.Location = new System.Drawing.Point(27, 161);
            this.btnAccep.Name = "btnAccep";
            this.btnAccep.Size = new System.Drawing.Size(162, 28);
            this.btnAccep.TabIndex = 1;
            this.btnAccep.Text = "Accept";
            this.btnAccep.UseVisualStyleBackColor = true;
            this.btnAccep.Click += new System.EventHandler(this.btnAccep_Click);
            // 
            // frmLanguageOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 195);
            this.Controls.Add(this.btnAccep);
            this.Controls.Add(this.lstLanguage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLanguageOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Option";
            this.Load += new System.EventHandler(this.frmLanguageOption_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLanguage;
        private System.Windows.Forms.Button btnAccep;
    }
}