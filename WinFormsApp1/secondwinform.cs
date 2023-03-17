using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Second_win_form : Form
    {
        public static Second_win_form Instance;
        public Label lab1;
        public Second_win_form()
        {
            InitializeComponent();
            lab1 = label_hi;
        }

        private void radioButton_brown_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_pickbackground_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_green_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cB_agree_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_agree.Checked)
            {
                button_magic.Enabled = true;
            }

            if (cB_choice.Checked)
            { button_magic.Enabled = true; }
            else { button_magic.Enabled = false; }
        }

        private void button_magic_Click(object sender, EventArgs e)
        {
            if (radioButton_pink.Checked) { Form2.Instance.BackColor = Color.Pink; }
            if (radioButton_orange.Checked) { Form2.Instance.BackColor = Color.Orange; }
            if (radioButton_brown.Checked) { Form2.Instance.BackColor = Color.Brown; }
            if (radioButton_blue.Checked) { Form2.Instance.BackColor = Color.Blue; }
            if (radioButton_white.Checked) { Form2.Instance.BackColor = Color.White; }

            if (radioButton_black.Checked) { Form2.Instance.ForeColor = Color.Black; }
            if (radioButton_red.Checked) { Form2.Instance.ForeColor = Color.Red; }
            if (radioButton_green.Checked) { Form2.Instance.ForeColor = Color.Green; }

            else
            {
                string b = "Please choose an option";
                MessageBox.Show(b, "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
