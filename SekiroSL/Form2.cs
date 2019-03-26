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
using System.Net;

namespace SekiroSL
{
    public partial class Form2 : Form
    {

        public List<FileInfo> FI = new List<FileInfo>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LanguageLabel.Text = (Owner as Form1).Jo["Language"].ToString();
            groupBox1.Text = (Owner as Form1).Jo["Hotkeys"].ToString();
            ClearButton1.Text = (Owner as Form1).Jo["Clear"].ToString();
            ClearButton2.Text = ClearButton1.Text;
            ApplyButton.Text = (Owner as Form1).Jo["Apply"].ToString();
            CancelButton.Text = (Owner as Form1).Jo["Cancel"].ToString();
            Text = (Owner as Form1).Jo["Settings"].ToString();
            AboutLink.Text = (Owner as Form1).Jo["About"].ToString();
            label2.Text = (Owner as Form1).Jo["Load"].ToString();
            label3.Text = (Owner as Form1).Jo["Save"].ToString();
            FI = GetFile(Environment.CurrentDirectory + @"\Localization\", ".");
            comboBox1.DataSource = FI;
            comboBox1.Text = Settings1.Default.Language;
            label1.Text = (Owner as Form1).Jo["File"].ToString();
            textBox4.Text = Settings1.Default.GameDirectory;
            label4.Text = (Owner as Form1).Jo["SoundEffectType"].ToString();
            radioButton1.Text = (Owner as Form1).Jo["Ting"].ToString();
            radioButton2.Text = (Owner as Form1).Jo["Google"].ToString();
            radioButton3.Text = (Owner as Form1).Jo["Mute"].ToString();
            if (Settings1.Default.SoundType == "Mute")
            {
                radioButton3.Checked = true;
            }
            else if (Settings1.Default.SoundType == "Google")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }

            if (Settings1.Default.LoadModifier == 1)
            {
                checkBox3.Checked = true;
            }
            else if (Settings1.Default.LoadModifier == 2)
            {
                checkBox1.Checked = true;
            }
            else if (Settings1.Default.LoadModifier == 3)
            {
                checkBox1.Checked = true;
                checkBox3.Checked = true;
            }
            else if (Settings1.Default.LoadModifier == 4)
            {
                checkBox2.Checked = true;
            }
            else if (Settings1.Default.LoadModifier == 5)
            {
                checkBox3.Checked = true;
                checkBox2.Checked = true;
            }
            else if (Settings1.Default.LoadModifier == 6)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }
            else if (Settings1.Default.LoadModifier == 7)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }
            else if (Settings1.Default.LoadModifier == 0)
            {
                checkBox4.Checked = true;
            }

            if (Settings1.Default.SaveModifier == 1)
            {
                checkBox6.Checked = true;
            }
            else if (Settings1.Default.SaveModifier == 2)
            {
                checkBox8.Checked = true;
            }
            else if (Settings1.Default.SaveModifier == 3)
            {
                checkBox8.Checked = true;
                checkBox6.Checked = true;
            }
            else if (Settings1.Default.LoadModifier == 4)
            {
                checkBox7.Checked = true;
            }
            else if (Settings1.Default.SaveModifier == 5)
            {
                checkBox6.Checked = true;
                checkBox7.Checked = true;
            }
            else if (Settings1.Default.SaveModifier == 6)
            {
                checkBox8.Checked = true;
                checkBox7.Checked = true;
            }
            else if (Settings1.Default.SaveModifier == 7)
            {
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;
            }
            else if (Settings1.Default.SaveModifier == 0)
            {
                checkBox5.Checked = true;
            }

            LoadHotkey.Text = Settings1.Default.LoadHotkey.ToString();
            SaveHotKey.Text = Settings1.Default.SaveHotkey.ToString();
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
            ApplyButton.Text = (Owner as Form1).Jo["Apply"].ToString();
            CancelButton.Text = (Owner as Form1).Jo["Cancel"].ToString();
            Text = (Owner as Form1).Jo["Settings"].ToString();
            AboutLink.Text = (Owner as Form1).Jo["About"].ToString();
            label2.Text = (Owner as Form1).Jo["Load"].ToString();
            label3.Text = (Owner as Form1).Jo["Save"].ToString();
            label1.Text = (Owner as Form1).Jo["File"].ToString();
            button1.Text = (Owner as Form1).Jo["CheckUpdate"].ToString();
            label4.Text = (Owner as Form1).Jo["SoundEffectType"].ToString();
            radioButton1.Text = (Owner as Form1).Jo["Ting"].ToString();
            radioButton2.Text = (Owner as Form1).Jo["Google"].ToString();
            radioButton3.Text = (Owner as Form1).Jo["Mute"].ToString();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int LoadMValue = 0;
            int SaveMValue = 0;
            if (checkBox1.Checked == true)
                LoadMValue += 2;
            if (checkBox2.Checked == true)
                LoadMValue += 4;
            if (checkBox3.Checked == true)
                LoadMValue += 1;
            if (checkBox8.Checked == true)
                SaveMValue += 2;
            if (checkBox7.Checked == true)
                SaveMValue += 4;
            if (checkBox6.Checked == true)
                SaveMValue += 1;
            Settings1.Default.LoadModifier = LoadMValue;
            Settings1.Default.SaveModifier = SaveMValue;
            if(LoadHotkey.Text != "Back" && LoadHotkey.Text != "Space" && LoadHotkey.Text != "" && LoadHotkey.Text != "None")
            {
                char[] Temp = LoadHotkey.Text.ToCharArray();
                Settings1.Default.LoadHotkey = (Keys)Temp[0];
            }
            else if(LoadHotkey.Text == "Back")
            {
                Settings1.Default.LoadHotkey = Keys.Back;
            }
            else if(LoadHotkey.Text == "Space")
            {
                Settings1.Default.LoadHotkey = Keys.Space;
            }
            else
            {
                Settings1.Default.LoadHotkey = Keys.None;
            }

            if (SaveHotKey.Text != "Back" && SaveHotKey.Text != "Space" && SaveHotKey.Text != "" && SaveHotKey.Text != "None")
            {
                char[] Temp = SaveHotKey.Text.ToCharArray();
                Settings1.Default.SaveHotkey = (Keys)Temp[0];
            }
            else if (SaveHotKey.Text == "Back")
            {
                Settings1.Default.SaveHotkey = Keys.Back;
            }
            else if (SaveHotKey.Text == "Space")
            {
                Settings1.Default.SaveHotkey = Keys.Space;
            }
            else
            {
                Settings1.Default.SaveHotkey = Keys.None;
            }

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
            MessageBox.Show((Owner as Form1).Jo["CannotTransferAccount"].ToString());
            openFileDialog1.Title = (Owner as Form1).Jo["File"].ToString();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "openFileDialog1")
            {
                textBox4.Text = openFileDialog1.FileName;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Settings1.Default.Reload();
            (Owner as Form1).ReTranslateForm();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sourcecode = GetHttpWebRequest("https://shenkspz.wixsite.com/collection/blank");
            if(sourcecode != null)
            {
                string VA = GetBetweenArr(sourcecode, "只狼存档工具&nbsp;<span style=\"font-size:17px;\">", "</span>");
                if(VA != null)
                {
                    if (VA != Settings1.Default.Version)
                    {
                        if ((int)MessageBox.Show((Owner as Form1).Jo["NewVersion"].ToString() + VA, (Owner as Form1).Jo["SekiroSL"].ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 6)
                        {
                            System.Diagnostics.Process.Start("https://github.com/ShenKSPZ/SekiroSaveLoadManager/release");
                        }
                    }
                    else
                    {
                        MessageBox.Show((Owner as Form1).Jo["AlreadyNewest"].ToString(), (Owner as Form1).Jo["SekiroSL"].ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Can't get source code");
                }
            }
            
        }

        public string GetHttpWebRequest(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(uri);
                myReq.UserAgent = "User-Agent:Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705";
                myReq.Accept = "*/*";
                myReq.KeepAlive = true;
                myReq.Headers.Add("Accept-Language", "zh-cn,en-us;q=0.5");
                HttpWebResponse result = (HttpWebResponse)myReq.GetResponse();
                Stream receviceStream = result.GetResponseStream();
                StreamReader readerOfStream = new StreamReader(receviceStream, System.Text.Encoding.GetEncoding("UTF-8"));
                string strHTML = readerOfStream.ReadToEnd();
                readerOfStream.Close();
                receviceStream.Close();
                result.Close();

                return strHTML;
            }
            catch (Exception ex)
            {
                throw new Exception("采集指定网址异常，" + ex.Message);
            }
        }

        public string GetBetweenArr(string str, string leftstr, string rightstr)
        {
            int leftIndex = str.IndexOf(leftstr);//左文本起始位置
            int leftlength = leftstr.Length;//左文本长度
            int rightIndex = 0;
            string temp = "";
            while (leftIndex != -1)
            {
                rightIndex = str.IndexOf(rightstr, leftIndex + leftlength);
                if (rightIndex == -1)
                {
                    break;
                }
                temp = str.Substring(leftIndex + leftlength, rightIndex - leftIndex - leftlength);
                leftIndex = str.IndexOf(leftstr, rightIndex + 1);
            }
            return temp;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Settings1.Default.SoundType = "Mute";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Settings1.Default.SoundType = "Google";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Settings1.Default.SoundType = "Ting";
        }

        private void LoadHotkey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 27)
            {
                LoadHotkey.Text = e.KeyChar.ToString().ToUpper();
                e.Handled = true;
            }
            else if(e.KeyChar == 8)
            {
                LoadHotkey.Text = "Back";
                e.Handled = true;
            }
            else if(e.KeyChar == 32)
            {
                LoadHotkey.Text = "Space";
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox5.Checked = false;
            }
        }

        private void SaveHotKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 27)
            {
                SaveHotKey.Text = e.KeyChar.ToString().ToUpper();
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                SaveHotKey.Text = "Back";
                e.Handled = true;
            }
            else if (e.KeyChar == 32)
            {
                SaveHotKey.Text = "Space";
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ClearButton1_Click(object sender, EventArgs e)
        {
            LoadHotkey.Text = "None";
            checkBox4.Checked = true;
        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            SaveHotKey.Text = "None";
            checkBox5.Checked = true;
        }
    }
}
