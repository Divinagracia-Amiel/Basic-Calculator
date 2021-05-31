﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string n = "";
        string op;
        double res;
        public Form1()
        {
            InitializeComponent();
        }

        private void ioScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            {
                if (ioScreen.Text != "" || n != "")
                {
                    ioScreen.Text = ioScreen.Text + " + ";
                    res = res + Convert.ToDouble(n);
                    op = "+";
                    n = "";
                }               
            }                
        }

        private void minus_Click(object sender, EventArgs e)
        {
            ioScreen.Text = ioScreen.Text + " - ";
        }

        private void div_Click(object sender, EventArgs e)
        {
            ioScreen.Text = ioScreen.Text + " ÷ ";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            ioScreen.Text = ioScreen.Text + " × ";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ioScreen.Text = String.Empty;
            n = "0";
            res = 0;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text == "")
            {
                n = "0";
                res = 0;
            }

            else if (ioScreen.Text.Length >= 1)
            {
                int end_io = ioScreen.Text.Length;
                char idx_end_io_ch = ioScreen.Text[end_io - 1];
                string idx_end_io = idx_end_io_ch.ToString();
                ioScreen.Text = ioScreen.Text.Remove(end_io - 1, 1);
                             
                if (idx_end_io == "+")
                {
                    res = 0;
                }
            }
            
            if (n.Length >= 1)
            {
                int end_n = n.Length;
                n = n.Remove(end_n - 1, 1);
            }
            
        }

        private void ans_Click(object sender, EventArgs e)
        {
           
            ioScreen.Text = ioScreen.Text + "ans";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text.Contains("+") == true)
            {
                res = res + Convert.ToDouble(n);
                ioScreen.Text = String.Empty;
                ioScreen.Text = res.ToString();
                n = "0";
            }

            else
            {
               
            }
         
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            ioScreen.Text = ioScreen.Text + ".";
        }

        private void neg_Click(object sender, EventArgs e)
        {
            ioScreen.Text = "-" + ioScreen.Text;
        }

        private void clPar_Click(object sender, EventArgs e)
        {
            ioScreen.Text = ioScreen.Text + ")";
        }

        private void opPar_Click(object sender, EventArgs e)
        {
            ioScreen.Text = ioScreen.Text + "(";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            n = n + "0";
            ioScreen.Text = ioScreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            n = n + "1";
            ioScreen.Text = ioScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            n = n + "2";
            ioScreen.Text = ioScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            n = n + "3";
            ioScreen.Text = ioScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            n = n + "4";
            ioScreen.Text = ioScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            n = n + "5";
            ioScreen.Text = ioScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            n = n + "6";
            ioScreen.Text = ioScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            n = n + "7";
            ioScreen.Text = ioScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            n = n + "8";
            ioScreen.Text = ioScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            n = n + "9";
            ioScreen.Text = ioScreen.Text + "9";
        }

    }
}
