using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoresApp
{
    public partial class Form1 : Form
    {
        public List<string> memberList = new List<string> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void MembersList_Click(object sender, EventArgs e)
        {
            if (textBox_Member1.Text != string.Empty)
            {
                memberList.Add(textBox_Member1.Text);
            }
            else
            {
                textBox_Member1.Visible = false;            
            }

            toolStripCombox_MemberList.Items.AddRange(memberList.ToArray());
        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
                  
        {
            //create an array to hold 9 strings. 
            const int SIZE = 9;
            string[] names = new string[SIZE];  

            //Get the names.
            names[0] = textBox_Member1.Text;
            names[1] = textBox_Member2.Text;
            names[2] = textBox_Member3.Text;
            names[3] = textBox_Member4.Text;
            names[4] = textBox_Member5.Text;
            names[5] = textBox_Member6.Text;
            names[6] = textBox_Member7.Text;
            names[7] = textBox_Member8.Text;
            names[8] = textBox_Member9.Text;

            //Dispaly the names.
            MessageBox.Show(names[0]);
            MessageBox.Show(names[1]);
            MessageBox.Show(names[2]);
            MessageBox.Show(names[3]);
            MessageBox.Show(names[4]);
            MessageBox.Show(names[5]);  
            MessageBox.Show(names[6]);
            MessageBox.Show(names[7]);
            MessageBox.Show(names[8]);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
