namespace Tiamat.WindowsForms
{
    partial class AnaliticAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaliticAccounts));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_add = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_add);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 435);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(698, 43);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(620, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 30);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Добави";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // listBox
            // 
            this.listBox.ContextMenuStrip = this.contextMenuStrip;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(3, 51);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(698, 378);
            this.listBox.TabIndex = 1;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem_Delete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(115, 26);
            // 
            // StripMenuItem_Delete
            // 
            this.StripMenuItem_Delete.Name = "StripMenuItem_Delete";
            this.StripMenuItem_Delete.Size = new System.Drawing.Size(114, 22);
            this.StripMenuItem_Delete.Text = "Изтрий";
            this.StripMenuItem_Delete.Click += new System.EventHandler(this.StripMenuItem_Delete_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(698, 42);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label_search);
            this.flowLayoutPanel2.Controls.Add(this.textBox_search);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(343, 36);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(3, 0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(51, 13);
            this.label_search.TabIndex = 1;
            this.label_search.Text = "Търсене";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(60, 3);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 20);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button_minus);
            this.flowLayoutPanel3.Controls.Add(this.button_plus);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(352, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(343, 36);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(265, 3);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(75, 23);
            this.button_minus.TabIndex = 0;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(184, 3);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(75, 23);
            this.button_plus.TabIndex = 1;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // AnaliticAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaliticAccounts";
            this.Text = "AnaliticAccounts";
            this.Load += new System.EventHandler(this.AnaliticAccounts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem_Delete;
    }
}