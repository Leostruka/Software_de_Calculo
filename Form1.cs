using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal val1 = 0, val2 = 0;
        string operation = "";
        bool dotVal1 = false, dotVal2 = false; 

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            operBox.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            operBox.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            operBox.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            operBox.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            operBox.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            operBox.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            operBox.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            operBox.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            operBox.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            operBox.Text += "9";
        }
        
        private void dot_Click(object sender, EventArgs e)
        {
            if (dotVal1 == false && val1 == 0)
            {
                operBox.Text += ".";
                dotVal1 = true;
            }
            else if (dotVal2 == false && val2 == 0);
        }
    }
}
