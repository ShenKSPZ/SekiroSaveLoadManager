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

namespace SekiroSL
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Text = (Owner as Form1).Jo["New Profile"].ToString();
            button1.Text = (Owner as Form1).Jo["Apply"].ToString();
            button2.Text = (Owner as Form1).Jo["Cancel"].ToString();
            label1 .Text = (Owner as Form1).Jo["Profile Name"].ToString();
            Console.WriteLine(Settings1.Default.GameDirectory.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ProfileNameBox.Text != "")
            {
                if(!Directory.Exists(Environment.CurrentDirectory + @"\Save\" + ProfileNameBox.Text))
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + @"\Save\" + ProfileNameBox.Text);
                    
                    Settings1.Default.Save();
                    Close();
                }
                else
                {
                    MessageBox.Show((Owner as Form1).Jo["Name already existed"].ToString()); 
                }
            }
            else
            {
                MessageBox.Show((Owner as Form1).Jo["Please enter profile name"].ToString());
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
