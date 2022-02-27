namespace MyGui
{
    partial class Form2
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
            this.PageText = new System.Windows.Forms.TextBox();
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.PageToLoad = new System.Windows.Forms.TextBox();
            this.LoadPrevButton = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.PropertiesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Links = new System.Windows.Forms.TextBox();
            this.labelLinks = new System.Windows.Forms.Label();
            this.labelSpells = new System.Windows.Forms.Label();
            this.Spells = new System.Windows.Forms.TextBox();
            this.labelEnemies = new System.Windows.Forms.Label();
            this.textBoxEnemies = new System.Windows.Forms.TextBox();
            this.FormLayout.SuspendLayout();
            this.ButtonsLayout.SuspendLayout();
            this.PropertiesLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormLayout
            // 
            this.FormLayout.AllowDrop = true;
            this.FormLayout.ColumnCount = 2;
            this.FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FormLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FormLayout.Controls.Add(this.PageText, 0, 0);
            this.FormLayout.Controls.Add(this.ButtonsLayout, 1, 1);
            this.FormLayout.Controls.Add(this.PropertiesLayout, 1, 0);
            this.FormLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormLayout.Location = new System.Drawing.Point(0, 0);
            this.FormLayout.Name = "FormLayout";
            this.FormLayout.RowCount = 2;
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FormLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FormLayout.Size = new System.Drawing.Size(800, 450);
            this.FormLayout.TabIndex = 0;
            // 
            // PageText
            // 
            this.PageText.AcceptsTab = true;
            this.PageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageText.Location = new System.Drawing.Point(3, 3);
            this.PageText.Multiline = true;
            this.PageText.Name = "PageText";
            this.FormLayout.SetRowSpan(this.PageText, 2);
            this.PageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PageText.Size = new System.Drawing.Size(394, 444);
            this.PageText.TabIndex = 0;
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.ColumnCount = 6;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsLayout.Controls.Add(this.buttonSave, 4, 0);
            this.ButtonsLayout.Controls.Add(this.buttonCancel, 5, 0);
            this.ButtonsLayout.Controls.Add(this.buttonLoad, 0, 0);
            this.ButtonsLayout.Controls.Add(this.PageToLoad, 2, 0);
            this.ButtonsLayout.Controls.Add(this.LoadPrevButton, 1, 0);
            this.ButtonsLayout.Controls.Add(this.buttonNextPage, 3, 0);
            this.ButtonsLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsLayout.Location = new System.Drawing.Point(403, 414);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 1;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsLayout.Size = new System.Drawing.Size(394, 33);
            this.ButtonsLayout.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(237, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(72, 27);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(315, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 27);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoad.Location = new System.Drawing.Point(3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(72, 27);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load Page";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // PageToLoad
            // 
            this.PageToLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageToLoad.Location = new System.Drawing.Point(120, 3);
            this.PageToLoad.Name = "PageToLoad";
            this.PageToLoad.Size = new System.Drawing.Size(72, 20);
            this.PageToLoad.TabIndex = 3;
            this.PageToLoad.Text = "0";
            // 
            // LoadPrevButton
            // 
            this.LoadPrevButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadPrevButton.Location = new System.Drawing.Point(81, 3);
            this.LoadPrevButton.Name = "LoadPrevButton";
            this.LoadPrevButton.Size = new System.Drawing.Size(33, 27);
            this.LoadPrevButton.TabIndex = 4;
            this.LoadPrevButton.Text = "<";
            this.LoadPrevButton.UseVisualStyleBackColor = true;
            this.LoadPrevButton.Click += new System.EventHandler(this.LoadPrevButton_Click);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNextPage.Location = new System.Drawing.Point(198, 3);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(33, 27);
            this.buttonNextPage.TabIndex = 5;
            this.buttonNextPage.Text = ">";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // PropertiesLayout
            // 
            this.PropertiesLayout.ColumnCount = 2;
            this.PropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PropertiesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PropertiesLayout.Controls.Add(this.Links, 1, 0);
            this.PropertiesLayout.Controls.Add(this.labelLinks, 0, 0);
            this.PropertiesLayout.Controls.Add(this.labelSpells, 0, 1);
            this.PropertiesLayout.Controls.Add(this.Spells, 1, 1);
            this.PropertiesLayout.Controls.Add(this.labelEnemies, 0, 2);
            this.PropertiesLayout.Controls.Add(this.textBoxEnemies, 1, 2);
            this.PropertiesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertiesLayout.Location = new System.Drawing.Point(403, 3);
            this.PropertiesLayout.Name = "PropertiesLayout";
            this.PropertiesLayout.RowCount = 5;
            this.PropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.PropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.PropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.PropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.PropertiesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.PropertiesLayout.Size = new System.Drawing.Size(394, 219);
            this.PropertiesLayout.TabIndex = 3;
            // 
            // Links
            // 
            this.Links.Dock = System.Windows.Forms.DockStyle.Top;
            this.Links.Location = new System.Drawing.Point(62, 3);
            this.Links.Name = "Links";
            this.Links.Size = new System.Drawing.Size(329, 20);
            this.Links.TabIndex = 2;
            // 
            // labelLinks
            // 
            this.labelLinks.AutoSize = true;
            this.labelLinks.Location = new System.Drawing.Point(3, 0);
            this.labelLinks.Name = "labelLinks";
            this.labelLinks.Size = new System.Drawing.Size(32, 13);
            this.labelLinks.TabIndex = 3;
            this.labelLinks.Text = "Links";
            // 
            // labelSpells
            // 
            this.labelSpells.AutoSize = true;
            this.labelSpells.Location = new System.Drawing.Point(3, 24);
            this.labelSpells.Name = "labelSpells";
            this.labelSpells.Size = new System.Drawing.Size(35, 13);
            this.labelSpells.TabIndex = 4;
            this.labelSpells.Text = "Spells";
            // 
            // Spells
            // 
            this.Spells.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spells.Location = new System.Drawing.Point(62, 27);
            this.Spells.Name = "Spells";
            this.Spells.Size = new System.Drawing.Size(329, 20);
            this.Spells.TabIndex = 5;
            // 
            // labelEnemies
            // 
            this.labelEnemies.AutoSize = true;
            this.labelEnemies.Location = new System.Drawing.Point(3, 48);
            this.labelEnemies.Name = "labelEnemies";
            this.labelEnemies.Size = new System.Drawing.Size(47, 13);
            this.labelEnemies.TabIndex = 6;
            this.labelEnemies.Text = "Enemies";
            // 
            // textBoxEnemies
            // 
            this.textBoxEnemies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEnemies.Location = new System.Drawing.Point(62, 51);
            this.textBoxEnemies.Name = "textBoxEnemies";
            this.textBoxEnemies.Size = new System.Drawing.Size(329, 20);
            this.textBoxEnemies.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormLayout);
            this.Name = "Form2";
            this.Text = "`";
            this.FormLayout.ResumeLayout(false);
            this.FormLayout.PerformLayout();
            this.ButtonsLayout.ResumeLayout(false);
            this.ButtonsLayout.PerformLayout();
            this.PropertiesLayout.ResumeLayout(false);
            this.PropertiesLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FormLayout;
        private System.Windows.Forms.TextBox PageText;
        private System.Windows.Forms.TableLayoutPanel ButtonsLayout;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox PageToLoad;
        private System.Windows.Forms.TableLayoutPanel PropertiesLayout;
        private System.Windows.Forms.TextBox Links;
        private System.Windows.Forms.Label labelLinks;
        private System.Windows.Forms.Label labelSpells;
        private System.Windows.Forms.TextBox Spells;
        private System.Windows.Forms.Button LoadPrevButton;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Label labelEnemies;
        private System.Windows.Forms.TextBox textBoxEnemies;
    }
}