using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal val1 = 0, val2 = 0, result = 0;
        string operation = "";
        bool dotVal1 = false, dotVal2 = false;

        // Alternate font size
        private void size18()
        {
            // Create a object font
            Font novaFonte = new Font("Courier New", 18, FontStyle.Bold);

            // Attribute font in the textbox
            resultBox.Font = novaFonte;
        }
        private void size28()
        {
            // Create a object font
            Font novaFonte = new Font("Courier New", 28, FontStyle.Bold);

            // Attribute font in the textbox
            resultBox.Font = novaFonte;
        }

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
            else if (dotVal2 == false && val2 == 0)
            {
                operBox.Text += ".";
                dotVal2 = true;
            }
        }

        private void som_Click(object sender, EventArgs e)
        {
            if (operBox.Text != "" || result != 0)
            {
                if (resultBox.Text == "")
                {
                    val1 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                    resultBox.Text = operBox.Text + "+";
                    operBox.Text = "";
                    operation = "sum";
                }
                else if (val2 != 0)
                {
                    val1 = result;
                    val2 = 0; result = 0;
                    resultBox.Text = Convert.ToString(val1) + "+";
                    size28();
                    operBox.Text = "";
                    operation = "sum";
                }
                else 
                {
                    val2 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                    result = val1 + val2;
                    val1 = result;
                    val2 = 0; result = 0;
                    resultBox.Text = Convert.ToString(val1) + "+";
                    size28();
                    operBox.Text = "";
                    operation = "sum";
                }
            }
            
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (val1 != 0 && val2 != 0 || val1 != 0 && operBox.Text != "")
            {
                if (operation == "sum")
                {
                    if (result == 0)
                    {
                        val2 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                        result = val1 + val2;
                        resultBox.Text += operBox.Text + "\r\n=" + Convert.ToString(result);
                        size18();
                        operBox.Text = "";
                    }
                    else
                    {
                        val1 = result;
                        result = val1 + val2;
                        resultBox.Text = Convert.ToString(val1) + "+" + val2 + "\r\n=" + result;
                        size18();
                        operBox.Text = "";
                    }
                }
            }
        }
    }
}
