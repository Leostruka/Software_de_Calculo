﻿namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.operBox = new System.Windows.Forms.TextBox();
            this.cancelEntry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operBox
            // 
            this.operBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.operBox.Enabled = false;
            this.operBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.operBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.operBox.Location = new System.Drawing.Point(11, 69);
            this.operBox.Name = "operBox";
            this.operBox.Size = new System.Drawing.Size(334, 35);
            this.operBox.TabIndex = 0;
            this.operBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cancelEntry
            // 
            this.cancelEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelEntry.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEntry.Location = new System.Drawing.Point(11, 119);
            this.cancelEntry.Name = "cancelEntry";
            this.cancelEntry.Size = new System.Drawing.Size(89, 89);
            this.cancelEntry.TabIndex = 1;
            this.cancelEntry.Text = "CE";
            this.cancelEntry.UseVisualStyleBackColor = true;
            this.cancelEntry.Click += new System.EventHandler(this.cancelEntry_Click);
            // 
            // clear
            // 
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(106, 119);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(89, 89);
            this.clear.TabIndex = 2;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // div
            // 
            this.div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.div.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(203, 119);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(89, 89);
            this.div.TabIndex = 3;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mult.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(298, 119);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(89, 89);
            this.mult.TabIndex = 4;
            this.mult.Text = "X";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // sub
            // 
            this.sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sub.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(298, 214);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(89, 89);
            this.sub.TabIndex = 8;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // nine
            // 
            this.nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(203, 214);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(89, 89);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eight.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(106, 214);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(89, 89);
            this.eight.TabIndex = 6;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(11, 214);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(89, 89);
            this.seven.TabIndex = 5;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // equal
            // 
            this.equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equal.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(298, 404);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(89, 184);
            this.equal.TabIndex = 16;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // three
            // 
            this.three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(203, 404);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(89, 89);
            this.three.TabIndex = 15;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(106, 404);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(89, 89);
            this.two.TabIndex = 14;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(11, 404);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(89, 89);
            this.one.TabIndex = 13;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // dot
            // 
            this.dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dot.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(205, 499);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(89, 89);
            this.dot.TabIndex = 19;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // zero
            // 
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(11, 499);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(186, 89);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // four
            // 
            this.four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(11, 309);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(89, 89);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(106, 309);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(89, 89);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(203, 309);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(89, 89);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // sum
            // 
            this.sum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sum.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(298, 309);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(89, 89);
            this.sum.TabIndex = 12;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.resultBox.Enabled = false;
            this.resultBox.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold);
            this.resultBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resultBox.Location = new System.Drawing.Point(11, 12);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(376, 63);
            this.resultBox.TabIndex = 2;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // del
            // 
            this.del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del.Location = new System.Drawing.Point(342, 74);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(44, 31);
            this.del.TabIndex = 20;
            this.del.Text = "⌫";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(402, 599);
            this.Controls.Add(this.del);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.cancelEntry);
            this.Controls.Add(this.operBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelEntry;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.TextBox operBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button del;
    }
}

