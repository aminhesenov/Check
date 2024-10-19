using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
         
            string username = textBox1.Text;
            string password = textBox2.Text;

            for(int i=0; i < Form1.userIndex; i++)
            {
                if (username == Form1.usernames[i])
                {
                    richTextBox1.Text = "User is found!";
                }
             
            }
        }
    }
}
