using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SekiroSL
{
    public partial class Form1 : Form
    {
        public Form2 f2 = new Form2();
        public Form3 f3 = new Form3();
        public Form4 f4 = new Form4();
        public Form5 f5 = new Form5();
        public Form6 f6 = new Form6();
        public string Language;
        public JObject Jo = new JObject();
        public DirectoryInfo Dir = new DirectoryInfo(Environment.CurrentDirectory + @"\Save\");
        public string nameofre = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f2.Owner = this;
            f3.Owner = this;
            f4.Owner = this;
            f5.Owner = this;
            f6.Owner = this;
            if(Settings1.Default.Language == "")
            {
                f4.ShowDialog();
            }
            Language = FileToString(Environment.CurrentDirectory + @"\Localization\" + Settings1.Default.Language);
            Jo = (JObject)JsonConvert.DeserializeObject(Language);
            //Translating UI
            ReTranslateForm();
            DirectoryInfo[] di = Dir.GetDirectories();
            comboBox1.DataSource = di;
            renameToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
            if (comboBox1.Items.Count == 0 || comboBox1.Text == "")
            {
                deleteToolStripMenuItem1.Enabled = false;
                renameToolStripMenuItem1.Enabled = false;
            }
            SortToolStripMenuItem.Available = false;
        }

        public void ReTranslateForm()
        {
            Text = Jo["SekiroSL"].ToString();
            NewProflie.Text = Jo["New Profile"].ToString();
            LoadButton.Text = Jo["Load"].ToString();
            SaveButton.Text = Jo["Save"].ToString();
            ReplaceButton.Text = Jo["Replace"].ToString();
            renameToolStripMenuItem.Text = Jo["Rename"].ToString();
            deleteToolStripMenuItem.Text = Jo["Delete"].ToString();
            renameToolStripMenuItem1.Text = Jo["Rename"].ToString();
            deleteToolStripMenuItem1.Text = Jo["Delete"].ToString();
            SortToolStripMenuItem.Text = Jo["Sort"].ToString();
            standardSortAZToolStripMenuItem.Text = Jo["StandardSortAZ"].ToString();
            naturalSortAZToolStripMenuItem.Text = Jo["NaturalSortAZ"].ToString();
            standardSortZAToolStripMenuItem.Text = Jo["StandardSortZA"].ToString();
            naturalSortZAToolStripMenuItem.Text = Jo["NaturalSortZA"].ToString();
        }
        public static string FileToString(string filePath)
        {
            string strData = "";
            try
            {
                string line;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        strData = strData + line;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return strData;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count > 1)
            {
                renameToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = true;
            }
            else if (listBox1.SelectedIndices.Count < 0)
            {
                renameToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                renameToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
            Settings1.Default.Upgrade();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            File.Copy(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\" + listBox1.Text, Settings1.Default.GameDirectory, true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(File.Exists(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\" + Settings1.Default.SaveFileName) == false)
            {
                File.Copy(Settings1.Default.GameDirectory, Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\" + Settings1.Default.SaveFileName, false);
                comboBox1_SelectedIndexChanged(null, null);
            }
            else
            {
                int index = 0;
                while (File.Exists(Environment.CurrentDirectory + @"\Save\" +comboBox1.Text + @"\" + index.ToString() + Settings1.Default.SaveFileName))
                {
                    index++;
                }
                File.Copy(Settings1.Default.GameDirectory, Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\"  + index.ToString() + Settings1.Default.SaveFileName, false);
                comboBox1_SelectedIndexChanged(null, null);
            }
        }

        private void ReplaceSave_Click(object sender, EventArgs e)
        {
            if((int)MessageBox.Show(Jo["Are you sure you want to reaplace?"].ToString(),Jo["SekiroSL"].ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 6)
            {
                File.Copy(Settings1.Default.GameDirectory, Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\" + listBox1.Text, true);
            }
        }

        private void NewProflie_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
            DirectoryInfo[] di = Dir.GetDirectories();
            comboBox1.DataSource = di;
            if(comboBox1.Text != "")
            {
                renameToolStripMenuItem1.Enabled = true;
                deleteToolStripMenuItem1.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<FileInfo> FileI = new List<FileInfo>();
            DirectoryInfo root = new DirectoryInfo(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text);
            FileInfo[] files = root.GetFiles();
            listBox1.DataSource = files;
            
        }

        private void standardSortAZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void naturalSortAZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void standardSortZAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void naturalSortZAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameofre = listBox1.Text;
            f5.ShowDialog();
        }

        public bool Rename(string Name)
        {
            if(File.Exists(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\" + Name) || Name == "")
            {
                return false;
            }
            else
            {
                File.Move(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\" + listBox1.Text, Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\" + Name);
                comboBox1_SelectedIndexChanged(null,null);
                return true;
            }
        }

        public bool RenameProfile(string Name)
        {
            if(Directory.Exists(Environment.CurrentDirectory + @"\Save\" + Name + @"\") || Name == "")
            {
                return false;
            }
            else
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Save\" + Name);
                string[] file = Directory.GetFiles(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text);
                for(int i = 0; i < file.Count(); i++)
                {
                    string[] a = Regex.Split(file[i], "\\\\");
                    Console.WriteLine(a[a.Count() - 1]);
                    File.Move(file[i], Environment.CurrentDirectory + @"\Save\" + Name + @"\" + a[a.Count() - 1]);
                }
                Directory.Delete(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\");
                DirectoryInfo[] di = Dir.GetDirectories();
                comboBox1.DataSource = di;
                return true;
            }
        }

        private void renameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nameofre = comboBox1.Text;
            f6.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndices.Count == 1)
            {
                if((int)MessageBox.Show(Jo["Are you sure you want to delete?"].ToString(), Jo["SekiroSL"].ToString() ,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 6)
                {
                    File.Delete(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\" + listBox1.Text);
                    comboBox1_SelectedIndexChanged(null,null);
                }
            }
            else
            {
                if ((int)MessageBox.Show(Jo["Are you sure you want to delete?"].ToString(), Jo["SekiroSL"].ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 6)
                {
                    ListBox.SelectedObjectCollection FG = listBox1.SelectedItems;
                    for (int i = 0; i < FG.Count; i++)
                    {
                        File.Delete(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\" + listBox1.GetItemText(FG[i]));
                        Console.WriteLine(listBox1.GetItemText(FG[i]));
                    }
                    comboBox1_SelectedIndexChanged(null, null);
                }                
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if((int)MessageBox.Show(Jo["Are you sure you want to delete?"].ToString(), Jo["SekiroSL"].ToString(),MessageBoxButtons.YesNo) == 6)
            {
                string[] file = Directory.GetFiles(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text);
                for (int i = 0; i < file.Count(); i++)
                {
                    File.Delete(file[i]);
                }
                Directory.Delete(Environment.CurrentDirectory + @"\Save\" + comboBox1.Text + @"\");
                DirectoryInfo[] di = Dir.GetDirectories();
                comboBox1.DataSource = di;
                if(comboBox1.Items.Count == 0)
                {
                    comboBox1.Text = "";
                }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.Items.Count);
            if (comboBox1.Items.Count == 0 || comboBox1.Text == "")
            {
                deleteToolStripMenuItem1.Enabled = false;
                renameToolStripMenuItem1.Enabled = false;
            }
        }
    }
}
