﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal val1 = 0, val2 = 0, result = 0;
        string operation = "";
        bool dotv = false;

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

        // Check if decimal is int number
        private decimal CheckAndRoundResult(decimal number)
        {
            if (IsRoundNumber(number))
            {
                return Math.Round(number);
            }
            else
            {
                return number;
            }
        }

        private bool IsRoundNumber(decimal number)
        {
            return Math.Round(number, 0) == number;
        }

        // Disable Numeric Buttons if equal is activate
        private void DisableNumericButtons()
        {
            zero.Enabled = false;
            one.Enabled = false;
            two.Enabled = false;
            three.Enabled = false;
            four.Enabled = false;
            five.Enabled = false;
            six.Enabled = false;
            seven.Enabled = false;
            eight.Enabled = false;
            nine.Enabled = false;
            dot.Enabled = false;
            cancelEntry.Enabled = false;
        }

        // Enable if operator or clar button is pressed
        private void EnableNumericButtons()
        {
            zero.Enabled = true;
            one.Enabled = true;
            two.Enabled = true;
            three.Enabled = true;
            four.Enabled = true;
            five.Enabled = true;
            six.Enabled = true;
            seven.Enabled = true;
            eight.Enabled = true;
            nine.Enabled = true;
            dot.Enabled = true;
            cancelEntry.Enabled = true;
        }

        // Start form
        public Form1()
        {
            InitializeComponent();
        }

        // On Click
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
            if (dotv == false && val1 == 0 || dotv == false && val2 == 0)
            {
                operBox.Text += ".";
                dotv = true;
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operBox.Text))
            {
                if (operBox.Text.Substring(operBox.Text.Length - 1) == ".")
                {
                    dotv = false;
                }
                operBox.Text = operBox.Text.Substring(0, operBox.Text.Length - 1);
            }
        }

        private void cancelEntry_Click(object sender, EventArgs e)
        {
            operBox.Text = "";
            dotv = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result = 0; val1 = 0; val2 = 0;
            operBox.Text = ""; resultBox.Text = "";
            dotv = false;
            EnableNumericButtons();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            if (operBox.Text != "" || result != 0)
            {
                dotv = false;
                EnableNumericButtons();

                if (resultBox.Text == "")
                {
                    val1 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                    resultBox.Text = operBox.Text + "x";
                    operBox.Text = "";
                    operation = "mult";
                }
                else if (val2 != 0)
                {
                    result = CheckAndRoundResult(result);
                    val1 = result;
                    val2 = 0; result = 0;
                    resultBox.Text = Convert.ToString(val1) + "x";
                    size28();
                    operBox.Text = "";
                    operation = "mult";
                }
                else
                {
                    val2 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                    result = val1 * val2;
                    val1 = CheckAndRoundResult(result);
                    val2 = 0; result = 0;
                    resultBox.Text = Convert.ToString(val1) + "x";
                    size28();
                    operBox.Text = "";
                    operation = "mult";
                }
            }
            else if (string.IsNullOrEmpty(operBox.Text) && val1 != 0)
            {
                resultBox.Text = Convert.ToString(val1) + "x";
                operation = "mult";
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (operBox.Text != "" || result != 0)
            {
                dotv = false;
                EnableNumericButtons();

                if (resultBox.Text == "")
                {
                    val1 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                    resultBox.Text = operBox.Text + "÷";
                    operBox.Text = "";
                    operation = "div";
                }
                else if (val2 != 0)
                {
                    result = CheckAndRoundResult(result);
                    val1 = result;
                    val2 = 0; result = 0;
                    resultBox.Text = Convert.ToString(val1) + "÷";
                    size28();
                    operBox.Text = "";
                    operation = "div";
                }
                else
                {
                    val2 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                    result = val1 / val2;
                    val1 = CheckAndRoundResult(result);
                    val2 = 0; result = 0;
                    resultBox.Text = Convert.ToString(val1) + "÷";
                    size28();
                    operBox.Text = "";
                    operation = "div";
                }
            }
            else if (string.IsNullOrEmpty(operBox.Text) && val1 != 0)
            {
                resultBox.Text = Convert.ToString(val1) + "÷";
                operation = "div";
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            if (operBox.Text != "" || result != 0)
            {
                dotv = false;
                EnableNumericButtons();

                if (resultBox.Text == "")
                {
                    val1 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                    resultBox.Text = operBox.Text + "+";
                    operBox.Text = "";
                    operation = "sum";
                }
                else if (val2 != 0)
                {
                    result = CheckAndRoundResult(result);
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
                    val1 = CheckAndRoundResult(result);
                    val2 = 0; result = 0;
                    resultBox.Text = Convert.ToString(val1) + "+";
                    size28();
                    operBox.Text = "";
                    operation = "sum";
                }
            }
            else if (string.IsNullOrEmpty(operBox.Text) && val1 != 0)
            {
                resultBox.Text = Convert.ToString(val1) + "+";
                operation = "sum";
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (operBox.Text != "" || result != 0)
            {
                dotv = false;
                EnableNumericButtons();

                if (resultBox.Text == "")
                {
                    val1 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                    resultBox.Text = operBox.Text + "-";
                    operBox.Text = "";
                    operation = "sub";
                }
                else if (val2 != 0)
                {
                    result = CheckAndRoundResult(result);
                    val1 = result;
                    val2 = 0; result = 0;
                    resultBox.Text = Convert.ToString(val1) + "-";
                    size28();
                    operBox.Text = "";
                    operation = "sub";
                }
                else
                {
                    val2 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                    result = val1 - val2;
                    val1 = CheckAndRoundResult(result);
                    val2 = 0; result = 0;
                    resultBox.Text = Convert.ToString(val1) + "-";
                    size28();
                    operBox.Text = "";
                    operation = "sub";
                }
            }
            else if (string.IsNullOrEmpty(operBox.Text) && val1 != 0)
            {
                resultBox.Text = Convert.ToString(val1) + "-";
                operation = "sub";
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (val1 != 0 && val2 != 0 || val1 != 0 && operBox.Text != "")
            {
                dotv = true;
                DisableNumericButtons();

                if (operation == "mult")
                {
                    if (result == 0)
                    {
                        val2 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                        result = val1 * val2;
                        result = CheckAndRoundResult(result);
                        resultBox.Text += operBox.Text + "\r\n=" + Convert.ToString(result);
                        size18();
                        operBox.Text = "";
                    }
                    else
                    {
                        val1 = result;
                        result = val1 * val2;
                        result = CheckAndRoundResult(result);
                        resultBox.Text = Convert.ToString(val1) + "x" + val2 + "\r\n=" + result;
                        size18();
                        operBox.Text = "";
                    }
                }
                if (operation == "div")
                {
                    if (result == 0)
                    {
                        val2 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                        result = val1 / val2;
                        result = CheckAndRoundResult(result);
                        resultBox.Text += operBox.Text + "\r\n=" + Convert.ToString(result);
                        size18();
                        operBox.Text = "";
                    }
                    else
                    {
                        val1 = result;
                        result = val1 / val2;
                        result = CheckAndRoundResult(result);
                        resultBox.Text = Convert.ToString(val1) + "÷" + val2 + "\r\n=" + result;
                        size18();
                        operBox.Text = "";
                    }
                }
                else if (operation == "sum")
                {
                    if (result == 0)
                    {
                        val2 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                        result = val1 + val2;
                        result = CheckAndRoundResult(result);
                        resultBox.Text += operBox.Text + "\r\n=" + Convert.ToString(result);
                        size18();
                        operBox.Text = "";
                    }
                    else
                    {
                        val1 = result;
                        result = val1 + val2;
                        result = CheckAndRoundResult(result);
                        resultBox.Text = Convert.ToString(val1) + "+" + val2 + "\r\n=" + result;
                        size18();
                        operBox.Text = "";
                    }
                }
                else if (operation == "sub")
                {
                    if (result == 0)
                    {
                        val2 = decimal.Parse(operBox.Text, CultureInfo.InvariantCulture);
                        result = val1 - val2;
                        result = CheckAndRoundResult(result);
                        resultBox.Text += operBox.Text + "\r\n=" + Convert.ToString(result);
                        size18();
                        operBox.Text = "";
                    }
                    else
                    {
                        val1 = result;
                        result = val1 - val2;
                        result = CheckAndRoundResult(result);
                        resultBox.Text = Convert.ToString(val1) + "-" + val2 + "\r\n=" + result;
                        size18();
                        operBox.Text = "";
                    }
                }
            }
        }
    }
}
