using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int hp = 10;
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                hp = 0;
                label4.Text = Convert.ToString(hp);
                //label4.Text = "0";
                MessageBox.Show("you died");
            }
            {
                if (radioButton2.Checked)
                {
                    hp = hp - 2;
                    label4.Text = Convert.ToString(hp);
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label4.Text = "0";
                MessageBox.Show("тебя подорвали");
            }
            {
                if (radioButton3.Checked)
                {
                    hp = hp - 1;
                    label4.Text = Convert.ToString(hp);
                    groupBox2.Visible = false;
                    groupBox3.Visible = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int value = rnd.Next(1, 2);
            if (value == 1)
            {
                hp = hp + 2;
            }
            if (value == 2)
            {
                hp = hp - 4;
            }
            label4.Text = Convert.ToString(hp);
            groupBox3.Visible = false;
            groupBox4.Visible = true;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                groupBox4.Visible = false;
                groupBox6.Visible = true;
                {

                }

            }
            if (radioButton7.Checked)
            {
                groupBox4.Visible = false;
                groupBox5.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                hp = hp - 2;
                label4.Text = Convert.ToString(hp);
                groupBox6.Visible = false;
                groupBox5.Visible = true;


            }
            if (radioButton9.Checked)
            {
                groupBox6.Visible = false;
                groupBox5.Visible = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                groupBox5.Visible = false;

            }
            if (radioButton10.Checked)
            {
                hp = hp - 4;
                label4.Text = Convert.ToString(hp);
                groupBox5.Visible = false;

            }
        }
    }
}