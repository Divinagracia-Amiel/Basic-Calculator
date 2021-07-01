using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {                
        double res;     //result
        double prev_res; //to store the previous result
        int nth = 0;    //nth key or nth operands
        int last_opIndex; //Used in backspace event, last ops index
        int last_numsIndex; //Used in backspace even, last ops index
        string multSym = "×";    //Symbol for multiplication
        string divSym = "÷";     //Symbol for Division
        string n = "";  //used to make variables seperate
        public Form1()
        {
            InitializeComponent();
        }

        //Methods           
        private void Add_text(string add_char)
        {
            if (n == "" || n == "0")
            {
                ioScreen.Text = String.Empty;
            }
            n = n + add_char;
            ioScreen.Text = ioScreen.Text + add_char;
        }

        private void addOutputscreen(string add_char)
        {
            output_screen.Text = output_screen.Text + add_char;
        }

        //Operation Events
        private void plus_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "" || n != "") //As to not make an error when ioScreen.Text is empty
            {    
                nth++;
                PEMDAS.add_num(double.Parse(n));
                PEMDAS.add_ops("+");
                addOutputscreen(n + " + ");           
                n = "";                  
            }               
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "" || n != "") //As to not make an error when ioScreen.Text is empty
            {
                nth++;
                PEMDAS.add_num(double.Parse(n));
                PEMDAS.add_ops("-");
                addOutputscreen(n + " - ");
                n = "";
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "" || n != "") //As to not make an error when ioScreen.Text is empty
            {
                nth++;
                PEMDAS.add_num(double.Parse(n));
                PEMDAS.add_ops(divSym);
                addOutputscreen(n + " " + divSym + " ");
                n = "";
            }            
        }

        private void mult_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "" || n != "") //As to not make an error when ioScreen.Text is empty
            {
                nth++;
                PEMDAS.add_num(double.Parse(n));
                PEMDAS.add_ops(multSym);
                addOutputscreen(n + " " + multSym + " ");
                n = "";
            }
        }

        //Other Events
        private void sqr_function_Click(object sender, EventArgs e)
        {

        }

        private void reciprocal_Click(object sender, EventArgs e)
        {

        }

        private void percent_Click(object sender, EventArgs e)
        {

        }

        private void sqrt_function_Click(object sender, EventArgs e)
        {

        }

        private void m_clear_Click(object sender, EventArgs e)
        {

        }

        private void m_recall_Click(object sender, EventArgs e)
        {

        }

        private void m_add_Click(object sender, EventArgs e)
        {

        }

        private void m_sub_Click(object sender, EventArgs e)
        {

        }

        private void m_store_Click(object sender, EventArgs e)
        {

        }
        private void clear_Click(object sender, EventArgs e)
        {
            ioScreen.Text = String.Empty;;          
            n = "";
        }
        private void clearE_Click(object sender, EventArgs e)
        {
            ioScreen.Text = String.Empty;
            output_screen.Text = String.Empty;
            PEMDAS.ops.Clear();
            PEMDAS.nums.Clear();
            n = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            last_opIndex = PEMDAS.ops.Count();
            last_numsIndex = PEMDAS.nums.Count();
            if (ioScreen.Text[0].ToString() == "-" && ioScreen.TextLength == 2)
            {
                ioScreen.Text = ioScreen.Text.Remove(ioScreen.TextLength - 1, 1);
                n = n.Remove(n.Length - 1, 1);
            }

            if (ioScreen.Text.Length >= 1)
            {
                ioScreen.Text = ioScreen.Text.Remove(ioScreen.TextLength - 1, 1);
                if (n.Length >= 1)
                {
                    n = n.Remove(n.Length - 1, 1);
                }
            }

            if (ioScreen.Text == "" || ioScreen.Text == "0") // Replacing current number with the previous one
            {
                if (output_screen.TextLength - n.Length - 3 > 0 && PEMDAS.nums.Count > 0)
                {
                    n = PEMDAS.nums[last_numsIndex - 1].ToString();
                    ioScreen.Text += n;
                    output_screen.Text = output_screen.Text.Remove(output_screen.TextLength - n.Length - 3, n.Length + 3);
                    PEMDAS.ops.RemoveAt(last_opIndex - 1);
                    last_opIndex = PEMDAS.ops.Count();
                }              
            }
            

            if (last_opIndex < last_numsIndex) // so that the ops list count is the same as nums list count
            {
                PEMDAS.nums.RemoveAt(last_numsIndex - 1);
            }          
        }
        private void neg_Click(object sender, EventArgs e)
        {
            if (n != "")
            {
                if (n.Contains("-") == false)
                {
                    ioScreen.Text = "-" + ioScreen.Text;
                    n = "-" + n;
                }
                else
                {
                    ioScreen.Text = ioScreen.Text.Remove(0, 1);
                    n = n.Remove(0, 1);
                }
            }           
        }

        private void ans_Click(object sender, EventArgs e)
        {
            ioScreen.Text = ioScreen.Text + "ans";
            n = prev_res.ToString();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (output_screen.Text != String.Empty)
            {
                res = PEMDAS.equal_function(n);
                addOutputscreen(n + " = ");
                hist_list.Text = "\n" + output_screen.Text.Substring(0, output_screen.TextLength - 3) + "\n= " + res.ToString() + "\n" + hist_list.Text;
                ioScreen.Text = res.ToString();
                prev_res = res;
                PEMDAS.ops.Clear();
                PEMDAS.nums.Clear();
            }
            else
            {
                res = double.Parse(ioScreen.Text);
                hist_list.Text = "\n" + "\n= " + res + hist_list.Text;
            }       
        }

        //Button Events
        private void btn_dot_Click(object sender, EventArgs e)
        {          
            Add_text(".");
        }       

        private void btn0_Click(object sender, EventArgs e)
        {          
            Add_text("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Add_text("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Add_text("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Add_text("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Add_text("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Add_text("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Add_text("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Add_text("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Add_text("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Add_text("9");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ioScreen.SelectAll();
            ioScreen.SelectionAlignment = HorizontalAlignment.Right;
            output_screen.SelectAll();
            output_screen.SelectionAlignment = HorizontalAlignment.Right;
            hist_list.SelectAll();
            hist_list.SelectionAlignment = HorizontalAlignment.Right;
            ioScreen.Text = "0";
        }
        private void ioScreen_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
