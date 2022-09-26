using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int CountTrue = 0;
        int Error = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox4.Checked == true)
                CountTrue++;
            else
                Error++;
            if (checkBox7.Checked == true && checkBox8.Checked == true)
                CountTrue++;
            else
                Error++;
            if (radioButton1.Checked == true)
                CountTrue++;
            else
                Error++;
            if (radioButton8.Checked == true)
                CountTrue++;
            else
                Error++;

            label5.Text = "Правильных ответов " + CountTrue + " из 4 ";
            label6.Text = "Ошибок " + Error;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
