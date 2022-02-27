namespace MyGui
{
    partial class Form1
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
            this.FormLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GameText = new System.Windows.Forms.TextBox();
            this.ButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.StatsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ApLabel = new System.Windows.Forms.Label();
            this.StaminaLabel = new System.Windows.Forms.Label();
            this.LuckLabel = new System.Windows.Forms.Label();
            this.MaxApLabel = new System.Windows.Forms.Label();
            this.MaxStaminaLabel = new System.Windows.Forms.Label();
            this.MaxLuckLabel = new System.Windows.Forms.Label();
            this.PageLabel = new System.Windows.Forms.Label();
            this.CoinLabel = new System.Windows.Forms.Label();
            this.labelProviant = new System.Windows.Forms.Label();
            this.textBoxEquipment = new System.Windows.Forms.TextBox();
            this.textBoxBonuses = new System.Windows.Forms.TextBox();
            this.textBoxCombatLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shamutantiHillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormLayout.SuspendLayout();
            this.ButtonLayout.SuspendLayout();
            this.StatsLayout.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormLayout
            // 
            this.FormLayout.AutoSize = true;
            this.FormLayout.ColumnCount = 2;
            this.FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.FormLayout.Controls.Add(this.GameText, 0, 0);
            this.FormLayout.Controls.Add(this.ButtonLayout, 1, 1);
            this.FormLayout.Controls.Add(this.StatsLayout, 1, 0);
            this.FormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormLayout.Location = new System.Drawing.Point(0, 24);
            this.FormLayout.Name = "FormLayout";
            this.FormLayout.RowCount = 2;
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.5446F));
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.4554F));
            this.FormLayout.Size = new System.Drawing.Size(800, 426);
            this.FormLayout.TabIndex = 1;
            // 
            // GameText
            // 
            this.GameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameText.Location = new System.Drawing.Point(3, 3);
            this.GameText.Multiline = true;
            this.GameText.Name = "GameText";
            this.GameText.ReadOnly = true;
            this.FormLayout.SetRowSpan(this.GameText, 2);
            this.GameText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GameText.Size = new System.Drawing.Size(474, 420);
            this.GameText.TabIndex = 0;
            this.GameText.Text = "GameText";
            // 
            // ButtonLayout
            // 
            this.ButtonLayout.ColumnCount = 5;
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayout.Controls.Add(this.button1, 0, 0);
            this.ButtonLayout.Controls.Add(this.button2, 1, 0);
            this.ButtonLayout.Controls.Add(this.button3, 2, 0);
            this.ButtonLayout.Controls.Add(this.button4, 3, 0);
            this.ButtonLayout.Controls.Add(this.button5, 4, 0);
            this.ButtonLayout.Controls.Add(this.button6, 0, 1);
            this.ButtonLayout.Controls.Add(this.button7, 1, 1);
            this.ButtonLayout.Controls.Add(this.button8, 2, 1);
            this.ButtonLayout.Controls.Add(this.button9, 3, 1);
            this.ButtonLayout.Controls.Add(this.button10, 4, 1);
            this.ButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLayout.Location = new System.Drawing.Point(483, 295);
            this.ButtonLayout.Name = "ButtonLayout";
            this.ButtonLayout.RowCount = 2;
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonLayout.Size = new System.Drawing.Size(314, 128);
            this.ButtonLayout.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(65, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(127, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(189, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(251, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 58);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(3, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 58);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(65, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 58);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(127, 67);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 58);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(189, 67);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 58);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(251, 67);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 58);
            this.button10.TabIndex = 9;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // StatsLayout
            // 
            this.StatsLayout.ColumnCount = 3;
            this.StatsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.StatsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.StatsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.StatsLayout.Controls.Add(this.ApLabel, 0, 0);
            this.StatsLayout.Controls.Add(this.StaminaLabel, 1, 0);
            this.StatsLayout.Controls.Add(this.LuckLabel, 2, 0);
            this.StatsLayout.Controls.Add(this.MaxApLabel, 0, 1);
            this.StatsLayout.Controls.Add(this.MaxStaminaLabel, 1, 1);
            this.StatsLayout.Controls.Add(this.MaxLuckLabel, 2, 1);
            this.StatsLayout.Controls.Add(this.PageLabel, 0, 2);
            this.StatsLayout.Controls.Add(this.CoinLabel, 1, 2);
            this.StatsLayout.Controls.Add(this.labelProviant, 2, 2);
            this.StatsLayout.Controls.Add(this.textBoxEquipment, 0, 3);
            this.StatsLayout.Controls.Add(this.textBoxBonuses, 0, 4);
            this.StatsLayout.Controls.Add(this.textBoxCombatLog, 1, 3);
            this.StatsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsLayout.Location = new System.Drawing.Point(483, 3);
            this.StatsLayout.Name = "StatsLayout";
            this.StatsLayout.RowCount = 5;
            this.StatsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.StatsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.StatsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.StatsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.StatsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.StatsLayout.Size = new System.Drawing.Size(314, 286);
            this.StatsLayout.TabIndex = 2;
            // 
            // ApLabel
            // 
            this.ApLabel.AutoSize = true;
            this.ApLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApLabel.Location = new System.Drawing.Point(3, 0);
            this.ApLabel.Name = "ApLabel";
            this.ApLabel.Size = new System.Drawing.Size(98, 13);
            this.ApLabel.TabIndex = 3;
            this.ApLabel.Text = "AP: 0";
            // 
            // StaminaLabel
            // 
            this.StaminaLabel.AutoSize = true;
            this.StaminaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StaminaLabel.Location = new System.Drawing.Point(107, 0);
            this.StaminaLabel.Name = "StaminaLabel";
            this.StaminaLabel.Size = new System.Drawing.Size(98, 13);
            this.StaminaLabel.TabIndex = 1;
            this.StaminaLabel.Text = "Stamina: 0";
            // 
            // LuckLabel
            // 
            this.LuckLabel.AutoSize = true;
            this.LuckLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LuckLabel.Location = new System.Drawing.Point(211, 0);
            this.LuckLabel.Name = "LuckLabel";
            this.LuckLabel.Size = new System.Drawing.Size(100, 13);
            this.LuckLabel.TabIndex = 5;
            this.LuckLabel.Text = "Luck: 0";
            // 
            // MaxApLabel
            // 
            this.MaxApLabel.AutoSize = true;
            this.MaxApLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxApLabel.Location = new System.Drawing.Point(3, 42);
            this.MaxApLabel.Name = "MaxApLabel";
            this.MaxApLabel.Size = new System.Drawing.Size(98, 13);
            this.MaxApLabel.TabIndex = 4;
            this.MaxApLabel.Text = "Max AP: 0";
            // 
            // MaxStaminaLabel
            // 
            this.MaxStaminaLabel.AutoSize = true;
            this.MaxStaminaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxStaminaLabel.Location = new System.Drawing.Point(107, 42);
            this.MaxStaminaLabel.Name = "MaxStaminaLabel";
            this.MaxStaminaLabel.Size = new System.Drawing.Size(98, 13);
            this.MaxStaminaLabel.TabIndex = 2;
            this.MaxStaminaLabel.Text = "Max Stamina: 0";
            // 
            // MaxLuckLabel
            // 
            this.MaxLuckLabel.AutoSize = true;
            this.MaxLuckLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MaxLuckLabel.Location = new System.Drawing.Point(211, 42);
            this.MaxLuckLabel.Name = "MaxLuckLabel";
            this.MaxLuckLabel.Size = new System.Drawing.Size(100, 13);
            this.MaxLuckLabel.TabIndex = 6;
            this.MaxLuckLabel.Text = "Max Luck: 0";
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PageLabel.Location = new System.Drawing.Point(3, 84);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(98, 13);
            this.PageLabel.TabIndex = 0;
            this.PageLabel.Text = "Page: 0";
            // 
            // CoinLabel
            // 
            this.CoinLabel.AutoSize = true;
            this.CoinLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoinLabel.Location = new System.Drawing.Point(107, 84);
            this.CoinLabel.Name = "CoinLabel";
            this.CoinLabel.Size = new System.Drawing.Size(98, 13);
            this.CoinLabel.TabIndex = 7;
            this.CoinLabel.Text = "Coins: 0";
            // 
            // labelProviant
            // 
            this.labelProviant.AutoSize = true;
            this.labelProviant.Location = new System.Drawing.Point(211, 84);
            this.labelProviant.Name = "labelProviant";
            this.labelProviant.Size = new System.Drawing.Size(58, 13);
            this.labelProviant.TabIndex = 8;
            this.labelProviant.Text = "Proviant: 0";
            // 
            // textBoxEquipment
            // 
            this.textBoxEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEquipment.Location = new System.Drawing.Point(3, 129);
            this.textBoxEquipment.Multiline = true;
            this.textBoxEquipment.Name = "textBoxEquipment";
            this.textBoxEquipment.ReadOnly = true;
            this.textBoxEquipment.Size = new System.Drawing.Size(98, 108);
            this.textBoxEquipment.TabIndex = 9;
            this.textBoxEquipment.Text = "Sword";
            // 
            // textBoxBonuses
            // 
            this.StatsLayout.SetColumnSpan(this.textBoxBonuses, 3);
            this.textBoxBonuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBonuses.Location = new System.Drawing.Point(3, 243);
            this.textBoxBonuses.Multiline = true;
            this.textBoxBonuses.Name = "textBoxBonuses";
            this.textBoxBonuses.ReadOnly = true;
            this.textBoxBonuses.Size = new System.Drawing.Size(308, 40);
            this.textBoxBonuses.TabIndex = 10;
            this.textBoxBonuses.Text = "Bonus:";
            // 
            // textBoxCombatLog
            // 
            this.StatsLayout.SetColumnSpan(this.textBoxCombatLog, 2);
            this.textBoxCombatLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCombatLog.Location = new System.Drawing.Point(107, 129);
            this.textBoxCombatLog.Multiline = true;
            this.textBoxCombatLog.Name = "textBoxCombatLog";
            this.textBoxCombatLog.ReadOnly = true;
            this.textBoxCombatLog.Size = new System.Drawing.Size(204, 108);
            this.textBoxCombatLog.TabIndex = 11;
            this.textBoxCombatLog.Text = "Combat log:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.bookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickABookToolStripMenuItem,
            this.editBookToolStripMenuItem,
            this.goToPageToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // pickABookToolStripMenuItem
            // 
            this.pickABookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shamutantiHillsToolStripMenuItem});
            this.pickABookToolStripMenuItem.Name = "pickABookToolStripMenuItem";
            this.pickABookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pickABookToolStripMenuItem.Text = "Pick a book";
            // 
            // shamutantiHillsToolStripMenuItem
            // 
            this.shamutantiHillsToolStripMenuItem.Name = "shamutantiHillsToolStripMenuItem";
            this.shamutantiHillsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.shamutantiHillsToolStripMenuItem.Text = "Shamutanti Hills";
            this.shamutantiHillsToolStripMenuItem.Click += new System.EventHandler(this.shamutantiHillsToolStripMenuItem_Click);
            // 
            // editBookToolStripMenuItem
            // 
            this.editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            this.editBookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editBookToolStripMenuItem.Text = "Edit Book";
            this.editBookToolStripMenuItem.Click += new System.EventHandler(this.editBookToolStripMenuItem_Click);
            // 
            // goToPageToolStripMenuItem
            // 
            this.goToPageToolStripMenuItem.Name = "goToPageToolStripMenuItem";
            this.goToPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToPageToolStripMenuItem.Text = "GoToPage";
            this.goToPageToolStripMenuItem.Click += new System.EventHandler(this.goToPageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormLayout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormLayout.ResumeLayout(false);
            this.FormLayout.PerformLayout();
            this.ButtonLayout.ResumeLayout(false);
            this.StatsLayout.ResumeLayout(false);
            this.StatsLayout.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FormLayout;
        private System.Windows.Forms.TextBox GameText;
        private System.Windows.Forms.TableLayoutPanel ButtonLayout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TableLayoutPanel StatsLayout;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Label StaminaLabel;
        private System.Windows.Forms.Label CoinLabel;
        private System.Windows.Forms.Label MaxLuckLabel;
        private System.Windows.Forms.Label LuckLabel;
        private System.Windows.Forms.Label MaxApLabel;
        private System.Windows.Forms.Label ApLabel;
        private System.Windows.Forms.Label MaxStaminaLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pickABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shamutantiHillsToolStripMenuItem;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label labelProviant;
        private System.Windows.Forms.TextBox textBoxEquipment;
        private System.Windows.Forms.TextBox textBoxBonuses;
        private System.Windows.Forms.TextBox textBoxCombatLog;
        private System.Windows.Forms.ToolStripMenuItem goToPageToolStripMenuItem;
    }
}

