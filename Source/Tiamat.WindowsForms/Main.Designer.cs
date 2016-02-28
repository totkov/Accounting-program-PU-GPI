namespace Tiamat.WindowsForms
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu_AccounNote = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AccounNote_New = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AccounNote_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AccounNote_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_AccounNote_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Balance = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Balance_New = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Balance_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Balance_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Balance_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools_Calculator = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools_Chart = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools_Chart_National = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tools_Chart_Personal = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help_Abot = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help_Documentation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_AccounNote,
            this.Menu_Balance,
            this.Menu_Tools,
            this.Menu_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(672, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Menu_AccounNote
            // 
            this.Menu_AccounNote.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_AccounNote_New,
            this.Menu_AccounNote_Open,
            this.Menu_AccounNote_Save,
            this.toolStripSeparator2,
            this.Menu_AccounNote_Print});
            this.Menu_AccounNote.Name = "Menu_AccounNote";
            this.Menu_AccounNote.Size = new System.Drawing.Size(118, 20);
            this.Menu_AccounNote.Text = "Счетоводен запис";
            // 
            // Menu_AccounNote_New
            // 
            this.Menu_AccounNote_New.Name = "Menu_AccounNote_New";
            this.Menu_AccounNote_New.Size = new System.Drawing.Size(152, 22);
            this.Menu_AccounNote_New.Text = "Нов";
            this.Menu_AccounNote_New.Click += new System.EventHandler(this.Menu_AccounNote_New_Click);
            // 
            // Menu_AccounNote_Open
            // 
            this.Menu_AccounNote_Open.Name = "Menu_AccounNote_Open";
            this.Menu_AccounNote_Open.Size = new System.Drawing.Size(152, 22);
            this.Menu_AccounNote_Open.Text = "Отвори";
            this.Menu_AccounNote_Open.Click += new System.EventHandler(this.Menu_AccounNote_Open_Click);
            // 
            // Menu_AccounNote_Save
            // 
            this.Menu_AccounNote_Save.Name = "Menu_AccounNote_Save";
            this.Menu_AccounNote_Save.Size = new System.Drawing.Size(152, 22);
            this.Menu_AccounNote_Save.Text = "Запис";
            this.Menu_AccounNote_Save.Click += new System.EventHandler(this.Menu_AccounNote_Save_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // Menu_AccounNote_Print
            // 
            this.Menu_AccounNote_Print.Name = "Menu_AccounNote_Print";
            this.Menu_AccounNote_Print.Size = new System.Drawing.Size(152, 22);
            this.Menu_AccounNote_Print.Text = "Печат";
            // 
            // Menu_Balance
            // 
            this.Menu_Balance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Balance_New,
            this.Menu_Balance_Open,
            this.Menu_Balance_Save,
            this.toolStripSeparator1,
            this.Menu_Balance_Print});
            this.Menu_Balance.Name = "Menu_Balance";
            this.Menu_Balance.Size = new System.Drawing.Size(129, 20);
            this.Menu_Balance.Text = "Оборотна ведомост";
            // 
            // Menu_Balance_New
            // 
            this.Menu_Balance_New.Name = "Menu_Balance_New";
            this.Menu_Balance_New.Size = new System.Drawing.Size(119, 22);
            this.Menu_Balance_New.Text = "Нов";
            this.Menu_Balance_New.Click += new System.EventHandler(this.Menu_Balance_New_Click);
            // 
            // Menu_Balance_Open
            // 
            this.Menu_Balance_Open.Name = "Menu_Balance_Open";
            this.Menu_Balance_Open.Size = new System.Drawing.Size(119, 22);
            this.Menu_Balance_Open.Text = "Отвори";
            // 
            // Menu_Balance_Save
            // 
            this.Menu_Balance_Save.Name = "Menu_Balance_Save";
            this.Menu_Balance_Save.Size = new System.Drawing.Size(119, 22);
            this.Menu_Balance_Save.Text = "Запиши";
            this.Menu_Balance_Save.Click += new System.EventHandler(this.Menu_Balance_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // Menu_Balance_Print
            // 
            this.Menu_Balance_Print.Name = "Menu_Balance_Print";
            this.Menu_Balance_Print.Size = new System.Drawing.Size(119, 22);
            this.Menu_Balance_Print.Text = "Печат";
            // 
            // Menu_Tools
            // 
            this.Menu_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Tools_Calculator,
            this.Menu_Tools_Chart});
            this.Menu_Tools.Name = "Menu_Tools";
            this.Menu_Tools.Size = new System.Drawing.Size(93, 20);
            this.Menu_Tools.Text = "Инструменти";
            // 
            // Menu_Tools_Calculator
            // 
            this.Menu_Tools_Calculator.Name = "Menu_Tools_Calculator";
            this.Menu_Tools_Calculator.Size = new System.Drawing.Size(142, 22);
            this.Menu_Tools_Calculator.Text = "Калкулатор";
            this.Menu_Tools_Calculator.Click += new System.EventHandler(this.Menu_Tools_Calculator_Click);
            // 
            // Menu_Tools_Chart
            // 
            this.Menu_Tools_Chart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Tools_Chart_National,
            this.Menu_Tools_Chart_Personal});
            this.Menu_Tools_Chart.Name = "Menu_Tools_Chart";
            this.Menu_Tools_Chart.Size = new System.Drawing.Size(142, 22);
            this.Menu_Tools_Chart.Text = "Сметкоплан";
            // 
            // Menu_Tools_Chart_National
            // 
            this.Menu_Tools_Chart_National.Name = "Menu_Tools_Chart_National";
            this.Menu_Tools_Chart_National.Size = new System.Drawing.Size(212, 22);
            this.Menu_Tools_Chart_National.Text = "Национален сметкоплан";
            this.Menu_Tools_Chart_National.Click += new System.EventHandler(this.Menu_Tools_Chart_National_Click);
            // 
            // Menu_Tools_Chart_Personal
            // 
            this.Menu_Tools_Chart_Personal.Name = "Menu_Tools_Chart_Personal";
            this.Menu_Tools_Chart_Personal.Size = new System.Drawing.Size(212, 22);
            this.Menu_Tools_Chart_Personal.Text = "Аналитични сметки";
            this.Menu_Tools_Chart_Personal.Click += new System.EventHandler(this.Menu_Tools_Chart_Personal_Click);
            // 
            // Menu_Help
            // 
            this.Menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Help_Abot,
            this.Menu_Help_Documentation});
            this.Menu_Help.Name = "Menu_Help";
            this.Menu_Help.Size = new System.Drawing.Size(62, 20);
            this.Menu_Help.Text = "Помощ";
            // 
            // Menu_Help_Abot
            // 
            this.Menu_Help_Abot.Name = "Menu_Help_Abot";
            this.Menu_Help_Abot.Size = new System.Drawing.Size(154, 22);
            this.Menu_Help_Abot.Text = "За нас";
            this.Menu_Help_Abot.Click += new System.EventHandler(this.Menu_Help_Abot_Click);
            // 
            // Menu_Help_Documentation
            // 
            this.Menu_Help_Documentation.Name = "Menu_Help_Documentation";
            this.Menu_Help_Documentation.Size = new System.Drawing.Size(154, 22);
            this.Menu_Help_Documentation.Text = "Документация";
            this.Menu_Help_Documentation.Click += new System.EventHandler(this.Menu_Help_Documentation_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 408);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "TT Tiamat";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu_AccounNote;
        private System.Windows.Forms.ToolStripMenuItem Menu_AccounNote_New;
        private System.Windows.Forms.ToolStripMenuItem Menu_AccounNote_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_AccounNote_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Menu_AccounNote_Print;
        private System.Windows.Forms.ToolStripMenuItem Menu_Balance;
        private System.Windows.Forms.ToolStripMenuItem Menu_Balance_New;
        private System.Windows.Forms.ToolStripMenuItem Menu_Balance_Open;
        private System.Windows.Forms.ToolStripMenuItem Menu_Balance_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Balance_Print;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools_Calculator;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools_Chart;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help_Abot;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help_Documentation;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools_Chart_National;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools_Chart_Personal;
    }
}

