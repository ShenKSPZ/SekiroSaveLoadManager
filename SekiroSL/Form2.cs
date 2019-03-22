using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SekiroSL
{
    public partial class Form2 : Form
    {

        public List<FileInfo> FI = new List<FileInfo>();

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LanguageLabel.Text = (Owner as Form1).Jo["Language"].ToString();
            groupBox1.Text = (Owner as Form1).Jo["Hotkeys"].ToString();
            ClearButton1.Text = (Owner as Form1).Jo["Clear"].ToString();
            ClearButton2.Text = ClearButton1.Text;
            ClearButton3.Text = ClearButton1.Text;
            ApplyButton.Text = (Owner as Form1).Jo["Apply"].ToString();
            CancelButton.Text = (Owner as Form1).Jo["Cancel"].ToString();
            Text = (Owner as Form1).Jo["Settings"].ToString();
            AboutLink.Text = (Owner as Form1).Jo["About"].ToString();
            label2.Text = (Owner as Form1).Jo["Load"].ToString();
            label3.Text = (Owner as Form1).Jo["Save"].ToString();
            label4.Text = (Owner as Form1).Jo["Replace"].ToString();
            FI = GetFile(Environment.CurrentDirectory + @"\Localization\", ".");
            comboBox1.DataSource = FI;
            comboBox1.Text = Settings1.Default.Language;
            label1.Text = (Owner as Form1).Jo["File"].ToString();
            textBox4.Text = Settings1.Default.GameDirectory;
        }

        public static List<FileInfo> GetFile(string path, string extName)
        {
            List<FileInfo> lst = new List<FileInfo>();
            string[] dir = Directory.GetDirectories(path);
            DirectoryInfo fdir = new DirectoryInfo(path);
            FileInfo[] file = fdir.GetFiles();
            if (file.Length != 0 || dir.Length != 0)
            {
                foreach (FileInfo f in file) 
                {
                    if (extName.ToLower().IndexOf(f.Extension.ToLower()) >= 0)
                    {
                        lst.Add(f);
                    }
                }
                foreach (string d in dir)
                {
                    GetFile(d, extName);  
                }
            }
            return lst;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            (Owner as Form1).Language = Form1.FileToString(Environment.CurrentDirectory + @"\Localization\" + comboBox1.Text);
            (Owner as Form1).Jo = (JObject)JsonConvert.DeserializeObject((Owner as Form1).Language);
            LanguageLabel.Text = (Owner as Form1).Jo["Language"].ToString();
            groupBox1.Text = (Owner as Form1).Jo["Hotkeys"].ToString();
            ClearButton1.Text = (Owner as Form1).Jo["Clear"].ToString();
            ClearButton2.Text = ClearButton1.Text;
            ClearButton3.Text = ClearButton1.Text;
            ApplyButton.Text = (Owner as Form1).Jo["Apply"].ToString();
            CancelButton.Text = (Owner as Form1).Jo["Cancel"].ToString();
            Text = (Owner as Form1).Jo["Settings"].ToString();
            AboutLink.Text = (Owner as Form1).Jo["About"].ToString();
            label2.Text = (Owner as Form1).Jo["Load"].ToString();
            label3.Text = (Owner as Form1).Jo["Save"].ToString();
            label4.Text = (Owner as Form1).Jo["Replace"].ToString();
            label1.Text = (Owner as Form1).Jo["File"].ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Settings1.Default.Language = comboBox1.Text;
            Settings1.Default.GameDirectory = textBox4.Text;
            Settings1.Default.Save();
            (Owner as Form1).ReTranslateForm();
            Close();
        }

        private void AboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ShenKSPZ/SekiroSaveLoadManager");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = (Owner as Form1).Jo["File"].ToString();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "openFileDialog1")
            {
                textBox4.Text = openFileDialog1.FileName;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
