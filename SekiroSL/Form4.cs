using System;
using System.IO;
using System.Collections.Generic;
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
    public partial class Form4 : Form
    {

        public List<FileInfo> FI = new List<FileInfo>();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            FI = Form2.GetFile(Environment.CurrentDirectory + @"\Localization\", ".");
            comboBox1.DataSource = FI;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings1.Default.Language = comboBox1.Text;
            (Owner as Form1).Language = Form1.FileToString(Environment.CurrentDirectory + @"\Localization\" + Settings1.Default.Language);
            (Owner as Form1).Jo = (JObject)JsonConvert.DeserializeObject((Owner as Form1).Language);
            button1.Text = (Owner as Form1).Jo["Apply"].ToString();
            label1.Text = (Owner as Form1).Jo["Language"].ToString() + ":";
            Text = (Owner as Form1).Jo["Language"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Environment.GetEnvironmentVariable("systemdrive") + @"\Users\" + Environment.UserName+@"\AppData\Roaming\Sekiro"))
            {
                openFileDialog1.FileName = Environment.GetEnvironmentVariable("systemdrive") + @"\Users\" + Environment.UserName + @"\AppData\Roaming\Sekiro";
                DirectoryInfo Dir = new DirectoryInfo(Environment.GetEnvironmentVariable("systemdrive") + @"\Users\" + Environment.UserName + @"\AppData\Roaming\Sekiro");
                DirectoryInfo[] di = Dir.GetDirectories();
                if(di.Count() == 1)
                {
                    Settings1.Default.GameDirectory = di[0].FullName + @"\" + Settings1.Default.SaveFileName;
                    MessageBox.Show((Owner as Form1).Jo["FindSekiro"].ToString());
                }
                else
                {
                    MessageBox.Show((Owner as Form1).Jo["SaveIntroduce"].ToString());
                    openFileDialog1.FileName = Environment.GetEnvironmentVariable("systemdrive") + @"\Users\" + Environment.UserName + @"\AppData\Roaming\Sekiro\S0000.sl2";
                    openFileDialog1.ShowDialog();
                    while (!openFileDialog1.CheckFileExists)
                    {
                        MessageBox.Show((Owner as Form1).Jo["SaveIntroduce"].ToString());
                        openFileDialog1.ShowDialog();
                    }
                    Settings1.Default.GameDirectory = openFileDialog1.FileName;
                }
            }
            else
            {
                MessageBox.Show((Owner as Form1).Jo["CannotFindSekiro"].ToString());
                openFileDialog1.ShowDialog();
                Settings1.Default.GameDirectory = openFileDialog1.FileName;
            }
            Settings1.Default.Save();
            Close();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings1.Default.Save();
        }
    }
}
