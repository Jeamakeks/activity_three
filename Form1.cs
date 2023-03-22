using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void othersTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBttn_Click(object sender, EventArgs e)
        {
            string str = " ";

            //checkBox1 = Japan
            if (checkBox1.Checked == true) 
            {
                str = str + checkBox1.Text;
                str += " ";
            }

            //checkBox2 = Philippines
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += " ";
            }

            //checkBox3 = Thailand
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += " ";
            }

            //checkBox4 = Australia
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += " ";
            }

            //othersCheckBox
            if (othersCheckBox.Checked == true) 
            {
                str = str + othersTextBox.Text;
                str += " ";
            }

            if (str != null) {
                MessageBox.Show("You Selected: \n" + str + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void othersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (othersCheckBox.Checked == false)
            {
                othersLabel.Visible = false;
                othersTextBox.Visible = false;
            }
            else {
                othersLabel.Visible = true;
                othersTextBox.Visible = true;
            }
        }

        private void closeBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            othersLabel.Visible = false;
            othersTextBox.Visible = false;
        }
    }
}
