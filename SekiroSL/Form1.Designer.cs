namespace SekiroSL
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardSortAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalSortAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardSortZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalSortZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewProflie = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(573, 268);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.SortToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 70);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // SortToolStripMenuItem
            // 
            this.SortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardSortAZToolStripMenuItem,
            this.naturalSortAZToolStripMenuItem,
            this.standardSortZAToolStripMenuItem,
            this.naturalSortZAToolStripMenuItem});
            this.SortToolStripMenuItem.Name = "SortToolStripMenuItem";
            this.SortToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.SortToolStripMenuItem.Text = "Sort";
            this.SortToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // standardSortAZToolStripMenuItem
            // 
            this.standardSortAZToolStripMenuItem.Name = "standardSortAZToolStripMenuItem";
            this.standardSortAZToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.standardSortAZToolStripMenuItem.Text = "StandardSort A-Z";
            this.standardSortAZToolStripMenuItem.Click += new System.EventHandler(this.standardSortAZToolStripMenuItem_Click);
            // 
            // naturalSortAZToolStripMenuItem
            // 
            this.naturalSortAZToolStripMenuItem.Name = "naturalSortAZToolStripMenuItem";
            this.naturalSortAZToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.naturalSortAZToolStripMenuItem.Text = "NaturalSort A-Z";
            this.naturalSortAZToolStripMenuItem.Click += new System.EventHandler(this.naturalSortAZToolStripMenuItem_Click);
            // 
            // standardSortZAToolStripMenuItem
            // 
            this.standardSortZAToolStripMenuItem.Name = "standardSortZAToolStripMenuItem";
            this.standardSortZAToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.standardSortZAToolStripMenuItem.Text = "StandardSort Z-A";
            this.standardSortZAToolStripMenuItem.Click += new System.EventHandler(this.standardSortZAToolStripMenuItem_Click);
            // 
            // naturalSortZAToolStripMenuItem
            // 
            this.naturalSortZAToolStripMenuItem.Name = "naturalSortZAToolStripMenuItem";
            this.naturalSortZAToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.naturalSortZAToolStripMenuItem.Text = "NaturalSort Z-A";
            this.naturalSortZAToolStripMenuItem.Click += new System.EventHandler(this.naturalSortZAToolStripMenuItem_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("宋体", 9F);
            this.SaveButton.Location = new System.Drawing.Point(182, 312);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(164, 26);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Font = new System.Drawing.Font("宋体", 9F);
            this.ReplaceButton.Location = new System.Drawing.Point(352, 312);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(164, 26);
            this.ReplaceButton.TabIndex = 5;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.ContextMenuStrip = this.contextMenuStrip2;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(451, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1,
            this.renameToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(124, 48);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // renameToolStripMenuItem1
            // 
            this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            this.renameToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.renameToolStripMenuItem1.Text = "Rename";
            this.renameToolStripMenuItem1.Click += new System.EventHandler(this.renameToolStripMenuItem1_Click);
            // 
            // NewProflie
            // 
            this.NewProflie.Font = new System.Drawing.Font("宋体", 9F);
            this.NewProflie.Location = new System.Drawing.Point(469, 12);
            this.NewProflie.Name = "NewProflie";
            this.NewProflie.Size = new System.Drawing.Size(118, 20);
            this.NewProflie.TabIndex = 7;
            this.NewProflie.Text = "New Profile";
            this.NewProflie.UseVisualStyleBackColor = true;
            this.NewProflie.Click += new System.EventHandler(this.NewProflie_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadButton.Font = new System.Drawing.Font("宋体", 9F);
            this.LoadButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LoadButton.Location = new System.Drawing.Point(12, 310);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(164, 28);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Settings
            // 
            this.Settings.BackgroundImage = global::SekiroSL.Properties.Resources.options_2;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Font = new System.Drawing.Font("宋体", 9F);
            this.Settings.Location = new System.Drawing.Point(551, 310);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(34, 34);
            this.Settings.TabIndex = 8;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 350);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.NewProflie);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LoadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button NewProflie;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardSortAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalSortAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardSortZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalSortZAToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
    }
}

