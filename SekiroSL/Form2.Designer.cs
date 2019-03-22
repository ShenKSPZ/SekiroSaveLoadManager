namespace SekiroSL
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
            this.ApplyButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearButton3 = new System.Windows.Forms.Button();
            this.ClearButton2 = new System.Windows.Forms.Button();
            this.ClearButton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReplaceHotkey = new System.Windows.Forms.TextBox();
            this.SaveHotKey = new System.Windows.Forms.TextBox();
            this.LoadHotkey = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AboutLink = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(122, 380);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(12, 9);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(53, 12);
            this.LanguageLabel.TabIndex = 2;
            this.LanguageLabel.Text = "Language";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearButton3);
            this.groupBox1.Controls.Add(this.ClearButton2);
            this.groupBox1.Controls.Add(this.ClearButton1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ReplaceHotkey);
            this.groupBox1.Controls.Add(this.SaveHotKey);
            this.groupBox1.Controls.Add(this.LoadHotkey);
            this.groupBox1.Location = new System.Drawing.Point(14, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotkeys";
            // 
            // ClearButton3
            // 
            this.ClearButton3.Location = new System.Drawing.Point(187, 146);
            this.ClearButton3.Name = "ClearButton3";
            this.ClearButton3.Size = new System.Drawing.Size(75, 23);
            this.ClearButton3.TabIndex = 8;
            this.ClearButton3.Text = "Clear";
            this.ClearButton3.UseVisualStyleBackColor = true;
            // 
            // ClearButton2
            // 
            this.ClearButton2.Location = new System.Drawing.Point(187, 86);
            this.ClearButton2.Name = "ClearButton2";
            this.ClearButton2.Size = new System.Drawing.Size(75, 23);
            this.ClearButton2.TabIndex = 7;
            this.ClearButton2.Text = "Clear";
            this.ClearButton2.UseVisualStyleBackColor = true;
            // 
            // ClearButton1
            // 
            this.ClearButton1.Location = new System.Drawing.Point(187, 33);
            this.ClearButton1.Name = "ClearButton1";
            this.ClearButton1.Size = new System.Drawing.Size(75, 23);
            this.ClearButton1.TabIndex = 6;
            this.ClearButton1.Text = "Clear";
            this.ClearButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Replace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Save";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Load";
            // 
            // ReplaceHotkey
            // 
            this.ReplaceHotkey.Enabled = false;
            this.ReplaceHotkey.Location = new System.Drawing.Point(6, 146);
            this.ReplaceHotkey.Name = "ReplaceHotkey";
            this.ReplaceHotkey.Size = new System.Drawing.Size(175, 21);
            this.ReplaceHotkey.TabIndex = 2;
            this.ReplaceHotkey.Text = "Developing开发中";
            // 
            // SaveHotKey
            // 
            this.SaveHotKey.Enabled = false;
            this.SaveHotKey.Location = new System.Drawing.Point(6, 86);
            this.SaveHotKey.Name = "SaveHotKey";
            this.SaveHotKey.Size = new System.Drawing.Size(175, 21);
            this.SaveHotKey.TabIndex = 1;
            this.SaveHotKey.Text = "Developing开发中";
            // 
            // LoadHotkey
            // 
            this.LoadHotkey.Enabled = false;
            this.LoadHotkey.Location = new System.Drawing.Point(6, 33);
            this.LoadHotkey.Name = "LoadHotkey";
            this.LoadHotkey.Size = new System.Drawing.Size(175, 21);
            this.LoadHotkey.TabIndex = 0;
            this.LoadHotkey.Text = "Developing开发中";
            this.LoadHotkey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(203, 380);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AboutLink
            // 
            this.AboutLink.AutoSize = true;
            this.AboutLink.Font = new System.Drawing.Font("宋体", 10F);
            this.AboutLink.Location = new System.Drawing.Point(225, 343);
            this.AboutLink.Name = "AboutLink";
            this.AboutLink.Size = new System.Drawing.Size(42, 14);
            this.AboutLink.TabIndex = 5;
            this.AboutLink.TabStop = true;
            this.AboutLink.Text = "About";
            this.AboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLink_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 21);
            this.button3.TabIndex = 11;
            this.button3.Text = "…";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 297);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 21);
            this.textBox4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Alpha1.0   Copyright by 深空";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.AboutLink);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ApplyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LoadHotkey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReplaceHotkey;
        private System.Windows.Forms.TextBox SaveHotKey;
        private System.Windows.Forms.Button ClearButton3;
        private System.Windows.Forms.Button ClearButton2;
        private System.Windows.Forms.Button ClearButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.LinkLabel AboutLink;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}