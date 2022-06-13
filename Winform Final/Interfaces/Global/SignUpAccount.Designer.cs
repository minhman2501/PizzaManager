namespace Winform_Final.Global
{
    partial class SignUpAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUp_usernameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reenterTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signUp_passwordTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.signUp_fullNameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adressTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.signUp_usernameTxt);
            this.panel1.Location = new System.Drawing.Point(29, 425);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel1.Size = new System.Drawing.Size(514, 45);
            this.panel1.TabIndex = 7;
            // 
            // signUp_usernameTxt
            // 
            this.signUp_usernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signUp_usernameTxt.BackColor = System.Drawing.Color.White;
            this.signUp_usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signUp_usernameTxt.Font = new System.Drawing.Font("Ubuntu Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_usernameTxt.Location = new System.Drawing.Point(13, 8);
            this.signUp_usernameTxt.Name = "signUp_usernameTxt";
            this.signUp_usernameTxt.Size = new System.Drawing.Size(490, 27);
            this.signUp_usernameTxt.TabIndex = 0;
            this.signUp_usernameTxt.Leave += new System.EventHandler(this.signUp_usernameTxt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label3.Location = new System.Drawing.Point(24, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.Location = new System.Drawing.Point(24, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(160)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 68);
            this.label1.TabIndex = 6;
            this.label1.Text = "Signing Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.FlatAppearance.BorderSize = 2;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(160)))));
            this.cancelBtn.Location = new System.Drawing.Point(290, 700);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(124, 44);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(207)))), ((int)(((byte)(160)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(421, 700);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(124, 44);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Sign Up";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.reenterTxt);
            this.panel3.Location = new System.Drawing.Point(29, 598);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel3.Size = new System.Drawing.Size(514, 45);
            this.panel3.TabIndex = 8;
            // 
            // reenterTxt
            // 
            this.reenterTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reenterTxt.BackColor = System.Drawing.Color.White;
            this.reenterTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reenterTxt.Font = new System.Drawing.Font("Ubuntu Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenterTxt.Location = new System.Drawing.Point(13, 10);
            this.reenterTxt.Name = "reenterTxt";
            this.reenterTxt.Size = new System.Drawing.Size(490, 27);
            this.reenterTxt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label4.Location = new System.Drawing.Point(24, 565);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Re-enter password:";
            // 
            // signUp_passwordTxt
            // 
            this.signUp_passwordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signUp_passwordTxt.BackColor = System.Drawing.Color.White;
            this.signUp_passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signUp_passwordTxt.Font = new System.Drawing.Font("Ubuntu Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_passwordTxt.Location = new System.Drawing.Point(13, 8);
            this.signUp_passwordTxt.Name = "signUp_passwordTxt";
            this.signUp_passwordTxt.Size = new System.Drawing.Size(489, 27);
            this.signUp_passwordTxt.TabIndex = 0;
            this.signUp_passwordTxt.Leave += new System.EventHandler(this.signUp_passwordTxt_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.signUp_passwordTxt);
            this.panel2.Location = new System.Drawing.Point(29, 517);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel2.Size = new System.Drawing.Size(514, 45);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label5.Location = new System.Drawing.Point(24, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label6.Location = new System.Drawing.Point(24, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Full Name:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.signUp_fullNameTxt);
            this.panel4.Location = new System.Drawing.Point(29, 116);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel4.Size = new System.Drawing.Size(514, 45);
            this.panel4.TabIndex = 11;
            // 
            // signUp_fullNameTxt
            // 
            this.signUp_fullNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signUp_fullNameTxt.BackColor = System.Drawing.Color.White;
            this.signUp_fullNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.signUp_fullNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signUp_fullNameTxt.Font = new System.Drawing.Font("Ubuntu Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_fullNameTxt.ForeColor = System.Drawing.Color.Black;
            this.signUp_fullNameTxt.Location = new System.Drawing.Point(13, 8);
            this.signUp_fullNameTxt.Name = "signUp_fullNameTxt";
            this.signUp_fullNameTxt.Size = new System.Drawing.Size(490, 27);
            this.signUp_fullNameTxt.TabIndex = 0;
            this.signUp_fullNameTxt.Leave += new System.EventHandler(this.signUp_fullNameTxt_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label7.Location = new System.Drawing.Point(24, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Address:";
            // 
            // adressTxt
            // 
            this.adressTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adressTxt.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTxt.Location = new System.Drawing.Point(29, 217);
            this.adressTxt.Multiline = true;
            this.adressTxt.Name = "adressTxt";
            this.adressTxt.Size = new System.Drawing.Size(514, 154);
            this.adressTxt.TabIndex = 12;
            this.adressTxt.Leave += new System.EventHandler(this.adressTxt_Leave);
            // 
            // SignUpAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(555, 756);
            this.Controls.Add(this.adressTxt);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpAccount";
            this.Text = "SignInAccount";
            this.Load += new System.EventHandler(this.SignUpAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox signUp_usernameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox reenterTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signUp_passwordTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox signUp_fullNameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adressTxt;
    }
}