using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Text = (Owner as Form1).Jo["Rename"].ToString();
            label1.Text = (Owner as Form1).Jo["Rename"].ToString();
            button1.Text = (Owner as Form1).Jo["Apply"].ToString();
            textBox1.Text = (Owner as Form1).nameofre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Owner as Form1).RenameProfile(textBox1.Text))
            {
                Close();
            }
            else
            {
                MessageBox.Show((Owner as Form1).Jo["File already existed or didn't enter the file name"].ToString());
            }
        }
    }
}
