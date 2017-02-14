namespace MMG_Soft_MailSender
{
    partial class frmlicence
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
            this.txtlicence = new System.Windows.Forms.TextBox();
            this.lbllicencemessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtlicence
            // 
            this.txtlicence.Location = new System.Drawing.Point(12, 82);
            this.txtlicence.Multiline = true;
            this.txtlicence.Name = "txtlicence";
            this.txtlicence.Size = new System.Drawing.Size(480, 230);
            this.txtlicence.TabIndex = 0;
            // 
            // lbllicencemessage
            // 
            this.lbllicencemessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbllicencemessage.Location = new System.Drawing.Point(41, 9);
            this.lbllicencemessage.Name = "lbllicencemessage";
            this.lbllicencemessage.Size = new System.Drawing.Size(409, 38);
            this.lbllicencemessage.TabIndex = 1;
            this.lbllicencemessage.Text = "لطفا  متن زیر را به ایمیل های زیر ارسال کنید تا کلید فعال سازی را دریافت کنید";
            this.lbllicencemessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(108, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "farajahesh_shomal@yahoo.com   info@sms-soft.com";
            // 
            // frmlicence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbllicencemessage);
            this.Controls.Add(this.txtlicence);
            this.Name = "frmlicence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اطلاعات ثبت";
            this.Load += new System.EventHandler(this.frmlicence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlicence;
        private System.Windows.Forms.Label lbllicencemessage;
        private System.Windows.Forms.Label label1;
    }
}