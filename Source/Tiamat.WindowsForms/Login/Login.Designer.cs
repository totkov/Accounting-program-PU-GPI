namespace Tiamat.WindowsForms
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.linkLabel_singUp = new System.Windows.Forms.LinkLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(68, 58);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(108, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Потребителско име\r\n";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(131, 88);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(45, 13);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Парола";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(182, 58);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(140, 20);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(182, 88);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(140, 20);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_login.Location = new System.Drawing.Point(182, 123);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(140, 30);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Вход";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            this.button_login.Validating += new System.ComponentModel.CancelEventHandler(this.button_login_Validating);
            // 
            // linkLabel_singUp
            // 
            this.linkLabel_singUp.AutoSize = true;
            this.linkLabel_singUp.Location = new System.Drawing.Point(235, 170);
            this.linkLabel_singUp.Name = "linkLabel_singUp";
            this.linkLabel_singUp.Size = new System.Drawing.Size(87, 13);
            this.linkLabel_singUp.TabIndex = 5;
            this.linkLabel_singUp.TabStop = true;
            this.linkLabel_singUp.Text = "Регистрирай се";
            this.linkLabel_singUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_singUp_LinkClicked);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.linkLabel_singUp);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.LinkLabel linkLabel_singUp;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}