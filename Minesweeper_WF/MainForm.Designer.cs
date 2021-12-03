
namespace Minesweeper_WF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новичокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x19ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.любительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x9ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x16ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x19ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.профиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x9ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.x16ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.x19ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продолжитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рекордыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelView1 = new Minesweeper_WF.PanelView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flagLabelView1 = new Minesweeper_WF.FlagLabelView();
            this.timerLabelView1 = new Minesweeper_WF.TimerLabelView();
            this.statusView1 = new Minesweeper_WF.StatusView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.debug = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.продолжитьИгруToolStripMenuItem,
            this.рекордыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 28);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новичокToolStripMenuItem,
            this.любительToolStripMenuItem,
            this.профиToolStripMenuItem,
            this.пользовательскийToolStripMenuItem});
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            // 
            // новичокToolStripMenuItem
            // 
            this.новичокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x9ToolStripMenuItem,
            this.x16ToolStripMenuItem,
            this.x19ToolStripMenuItem});
            this.новичокToolStripMenuItem.Name = "новичокToolStripMenuItem";
            this.новичокToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.новичокToolStripMenuItem.Text = "Новичок";
            // 
            // x9ToolStripMenuItem
            // 
            this.x9ToolStripMenuItem.Name = "x9ToolStripMenuItem";
            this.x9ToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.x9ToolStripMenuItem.Text = "9 x 9";
            this.x9ToolStripMenuItem.Click += new System.EventHandler(this.x9ToolStripMenuItem_Click);
            // 
            // x16ToolStripMenuItem
            // 
            this.x16ToolStripMenuItem.Name = "x16ToolStripMenuItem";
            this.x16ToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.x16ToolStripMenuItem.Text = "16 x 16";
            this.x16ToolStripMenuItem.Click += new System.EventHandler(this.x16ToolStripMenuItem_Click);
            // 
            // x19ToolStripMenuItem
            // 
            this.x19ToolStripMenuItem.Name = "x19ToolStripMenuItem";
            this.x19ToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.x19ToolStripMenuItem.Text = "30 x 16";
            this.x19ToolStripMenuItem.Click += new System.EventHandler(this.x19ToolStripMenuItem_Click);
            // 
            // любительToolStripMenuItem
            // 
            this.любительToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x9ToolStripMenuItem1,
            this.x16ToolStripMenuItem1,
            this.x19ToolStripMenuItem1});
            this.любительToolStripMenuItem.Name = "любительToolStripMenuItem";
            this.любительToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.любительToolStripMenuItem.Text = "Любитель";
            this.любительToolStripMenuItem.Click += new System.EventHandler(this.любительToolStripMenuItem_Click);
            // 
            // x9ToolStripMenuItem1
            // 
            this.x9ToolStripMenuItem1.Name = "x9ToolStripMenuItem1";
            this.x9ToolStripMenuItem1.Size = new System.Drawing.Size(139, 26);
            this.x9ToolStripMenuItem1.Text = "9 x 9";
            this.x9ToolStripMenuItem1.Click += new System.EventHandler(this.x9ToolStripMenuItem1_Click);
            // 
            // x16ToolStripMenuItem1
            // 
            this.x16ToolStripMenuItem1.Name = "x16ToolStripMenuItem1";
            this.x16ToolStripMenuItem1.Size = new System.Drawing.Size(139, 26);
            this.x16ToolStripMenuItem1.Text = "16 x 16";
            this.x16ToolStripMenuItem1.Click += new System.EventHandler(this.x16ToolStripMenuItem1_Click);
            // 
            // x19ToolStripMenuItem1
            // 
            this.x19ToolStripMenuItem1.Name = "x19ToolStripMenuItem1";
            this.x19ToolStripMenuItem1.Size = new System.Drawing.Size(139, 26);
            this.x19ToolStripMenuItem1.Text = "30 x 16";
            this.x19ToolStripMenuItem1.Click += new System.EventHandler(this.x19ToolStripMenuItem1_Click);
            // 
            // профиToolStripMenuItem
            // 
            this.профиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x9ToolStripMenuItem2,
            this.x16ToolStripMenuItem2,
            this.x19ToolStripMenuItem2});
            this.профиToolStripMenuItem.Name = "профиToolStripMenuItem";
            this.профиToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.профиToolStripMenuItem.Text = "Профи";
            // 
            // x9ToolStripMenuItem2
            // 
            this.x9ToolStripMenuItem2.Name = "x9ToolStripMenuItem2";
            this.x9ToolStripMenuItem2.Size = new System.Drawing.Size(139, 26);
            this.x9ToolStripMenuItem2.Text = "9 x 9";
            this.x9ToolStripMenuItem2.Click += new System.EventHandler(this.x9ToolStripMenuItem2_Click);
            // 
            // x16ToolStripMenuItem2
            // 
            this.x16ToolStripMenuItem2.Name = "x16ToolStripMenuItem2";
            this.x16ToolStripMenuItem2.Size = new System.Drawing.Size(139, 26);
            this.x16ToolStripMenuItem2.Text = "16 x 16";
            this.x16ToolStripMenuItem2.Click += new System.EventHandler(this.x16ToolStripMenuItem2_Click);
            // 
            // x19ToolStripMenuItem2
            // 
            this.x19ToolStripMenuItem2.Name = "x19ToolStripMenuItem2";
            this.x19ToolStripMenuItem2.Size = new System.Drawing.Size(139, 26);
            this.x19ToolStripMenuItem2.Text = "30 x 16";
            this.x19ToolStripMenuItem2.Click += new System.EventHandler(this.x19ToolStripMenuItem2_Click);
            // 
            // пользовательскийToolStripMenuItem
            // 
            this.пользовательскийToolStripMenuItem.Name = "пользовательскийToolStripMenuItem";
            this.пользовательскийToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.пользовательскийToolStripMenuItem.Text = "Пользовательский";
            // 
            // продолжитьИгруToolStripMenuItem
            // 
            this.продолжитьИгруToolStripMenuItem.Name = "продолжитьИгруToolStripMenuItem";
            this.продолжитьИгруToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.продолжитьИгруToolStripMenuItem.Text = "Продолжить";
            this.продолжитьИгруToolStripMenuItem.Click += new System.EventHandler(this.продолжитьИгруToolStripMenuItem_Click);
            // 
            // рекордыToolStripMenuItem
            // 
            this.рекордыToolStripMenuItem.Name = "рекордыToolStripMenuItem";
            this.рекордыToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.рекордыToolStripMenuItem.Text = "Рекорды";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 485);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelView1
            // 
            this.panelView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelView1.AutoSize = true;
            this.panelView1.Location = new System.Drawing.Point(354, 77);
            this.panelView1.Model = null;
            this.panelView1.Name = "panelView1";
            this.panelView1.Size = new System.Drawing.Size(0, 0);
            this.panelView1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.flagLabelView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.timerLabelView1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.statusView1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(702, 68);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // flagLabelView1
            // 
            this.flagLabelView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flagLabelView1.AutoSize = true;
            this.flagLabelView1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flagLabelView1.Location = new System.Drawing.Point(3, 13);
            this.flagLabelView1.Model = null;
            this.flagLabelView1.Name = "flagLabelView1";
            this.flagLabelView1.Size = new System.Drawing.Size(80, 41);
            this.flagLabelView1.TabIndex = 2;
            this.flagLabelView1.Text = "flags";
            this.flagLabelView1.Click += new System.EventHandler(this.flagLabelView1_Click);
            // 
            // timerLabelView1
            // 
            this.timerLabelView1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timerLabelView1.AutoSize = true;
            this.timerLabelView1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabelView1.Location = new System.Drawing.Point(612, 13);
            this.timerLabelView1.Model = null;
            this.timerLabelView1.Name = "timerLabelView1";
            this.timerLabelView1.Size = new System.Drawing.Size(87, 41);
            this.timerLabelView1.TabIndex = 3;
            this.timerLabelView1.Text = "timer";
            // 
            // statusView1
            // 
            this.statusView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusView1.Location = new System.Drawing.Point(288, 3);
            this.statusView1.Model = null;
            this.statusView1.Name = "statusView1";
            this.statusView1.Size = new System.Drawing.Size(125, 62);
            this.statusView1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusView1.TabIndex = 4;
            this.statusView1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(388, 0);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(50, 20);
            this.debug.TabIndex = 4;
            this.debug.Text = "label1";
            this.debug.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(708, 513);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Minesweeper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новичокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x19ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem любительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x9ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x16ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x19ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem профиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x9ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem x16ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem x19ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem пользовательскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продолжитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рекордыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PanelView panelView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FlagLabelView flagLabelView1;
        private TimerLabelView timerLabelView1;
        private System.Windows.Forms.Label debug;
        private StatusView statusView1;
    }
}

