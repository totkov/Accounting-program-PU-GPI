namespace Tiamat.WindowsForms
{
    partial class AddAnaliticAccount
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
            this.label_number = new System.Windows.Forms.Label();
            this.label_extention = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_newname = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.textBox_extention = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_newname = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(12, 35);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(96, 13);
            this.label_number.TabIndex = 0;
            this.label_number.Text = "Номер на сметка";
            // 
            // label_extention
            // 
            this.label_extention.AutoSize = true;
            this.label_extention.Location = new System.Drawing.Point(12, 64);
            this.label_extention.Name = "label_extention";
            this.label_extention.Size = new System.Drawing.Size(70, 13);
            this.label_extention.TabIndex = 1;
            this.label_extention.Text = "Разширение";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(185, 35);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 13);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Име";
            // 
            // label_newname
            // 
            this.label_newname.AutoSize = true;
            this.label_newname.Location = new System.Drawing.Point(185, 65);
            this.label_newname.Name = "label_newname";
            this.label_newname.Size = new System.Drawing.Size(29, 13);
            this.label_newname.TabIndex = 3;
            this.label_newname.Text = "Име";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(107, 35);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(72, 20);
            this.textBox_number.TabIndex = 4;
            // 
            // textBox_extention
            // 
            this.textBox_extention.Location = new System.Drawing.Point(107, 61);
            this.textBox_extention.Name = "textBox_extention";
            this.textBox_extention.Size = new System.Drawing.Size(72, 20);
            this.textBox_extention.TabIndex = 5;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(230, 35);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(80, 20);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_newname
            // 
            this.textBox_newname.Location = new System.Drawing.Point(230, 62);
            this.textBox_newname.Name = "textBox_newname";
            this.textBox_newname.Size = new System.Drawing.Size(80, 20);
            this.textBox_newname.TabIndex = 7;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(230, 124);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(80, 20);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "ДОБАВИ";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // AddAnaliticAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 156);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_newname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_extention);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label_newname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_extention);
            this.Controls.Add(this.label_number);
            this.Name = "AddAnaliticAccount";
            this.Text = "AddAnaliticAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_extention;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_newname;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_extention;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_newname;
        private System.Windows.Forms.Button button_add;
    }
}