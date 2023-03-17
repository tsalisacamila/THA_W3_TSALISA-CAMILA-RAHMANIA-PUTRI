using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public static Form2 Instance;

        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Second_win_form form = new Second_win_form();
            form.Show();
            string a = "Hi, my name is " + textBox_name.Text + " and my favorite artist is " + textBox_mfa.Text;
            Second_win_form.Instance.lab1.Text = a;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_form_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_form.Checked)
            {
                button_submit.Enabled = true;
            }
            else
            {
                button_submit.Enabled = false;
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string isi = "Please fill in with the correct input";
            if (textBox_name.Text == "")
            {
                MessageBox.Show(isi, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (textBox_mfa.Text == "")
            {
                MessageBox.Show(isi, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
