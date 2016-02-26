namespace Tiamat.WindowsForms
{
    partial class SignUp
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
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_RePass = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_RePass = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.linkLabel_BackToLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(85, 35);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(108, 13);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Потребителско име";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(148, 60);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(45, 13);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Парола";
            // 
            // label_RePass
            // 
            this.label_RePass.AutoSize = true;
            this.label_RePass.Location = new System.Drawing.Point(104, 86);
            this.label_RePass.Name = "label_RePass";
            this.label_RePass.Size = new System.Drawing.Size(89, 13);
            this.label_RePass.TabIndex = 2;
            this.label_RePass.Text = "Повтори парола";
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.Location = new System.Drawing.Point(158, 113);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(35, 13);
            this.label_Mail.TabIndex = 3;
            this.label_Mail.Text = "E-mail";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(164, 140);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(29, 13);
            this.label_FirstName.TabIndex = 4;
            this.label_FirstName.Text = "Име";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(137, 167);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(56, 13);
            this.label_LastName.TabIndex = 5;
            this.label_LastName.Text = "Фамилия";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(199, 32);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(140, 20);
            this.textBox_Username.TabIndex = 6;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(199, 57);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(140, 20);
            this.textBox_Password.TabIndex = 7;
            // 
            // textBox_RePass
            // 
            this.textBox_RePass.Location = new System.Drawing.Point(199, 83);
            this.textBox_RePass.Name = "textBox_RePass";
            this.textBox_RePass.PasswordChar = '*';
            this.textBox_RePass.Size = new System.Drawing.Size(140, 20);
            this.textBox_RePass.TabIndex = 8;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(199, 110);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(140, 20);
            this.textBox_Mail.TabIndex = 9;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(199, 137);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(140, 20);
            this.textBox_FirstName.TabIndex = 10;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(199, 164);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(140, 20);
            this.textBox_LastName.TabIndex = 11;
            // 
            // button_SignUp
            // 
            this.button_SignUp.Location = new System.Drawing.Point(199, 203);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(140, 23);
            this.button_SignUp.TabIndex = 12;
            this.button_SignUp.Text = "Регистрирай се";
            this.button_SignUp.UseVisualStyleBackColor = true;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // linkLabel_BackToLogin
            // 
            this.linkLabel_BackToLogin.AutoSize = true;
            this.linkLabel_BackToLogin.Location = new System.Drawing.Point(199, 233);
            this.linkLabel_BackToLogin.Name = "linkLabel_BackToLogin";
            this.linkLabel_BackToLogin.Size = new System.Drawing.Size(129, 13);
            this.linkLabel_BackToLogin.TabIndex = 13;
            this.linkLabel_BackToLogin.TabStop = true;
            this.linkLabel_BackToLogin.Text = "Вече имам регистрация";
            this.linkLabel_BackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_BackToLogin_LinkClicked);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.linkLabel_BackToLogin);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_RePass);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_Mail);
            this.Controls.Add(this.label_RePass);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_RePass;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_RePass;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.LinkLabel linkLabel_BackToLogin;
    }
}