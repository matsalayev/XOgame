using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOgame
{
    public partial class Boshlash : Form
    {
        public Boshlash()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) Class1.who = 'x';
            else if (radioButton2.Checked == true) Class1.who = 'o';
            if (label2.Text == "💻") Class1.program = true;
            else Class1.program = false;
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton1.ForeColor=Color.Green; radioButton2.ForeColor=Color.Red;
                radioButton2.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton2.ForeColor = Color.Green; radioButton1.ForeColor = Color.Red;
                radioButton1.Checked = false;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(0, 120, 215);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = (label2.Text == "💻") ? label2.Text = "🙎‍♂️" : "💻";
        }
    }
}
