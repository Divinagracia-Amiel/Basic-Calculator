using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Control panelVal;
        double mem_pageVal;
        public int name = 1;
        public int panel_newLoc_multiplier = 0;
        double res;     //result
        double prev_res; //to store the previous result
        int nth = 0;    //nth key or nth operands
        int last_opIndex; //Used in backspace event, last ops index
        int last_numsIndex; //Used in backspace even, last ops index
        string multSym = "×";    //Symbol for multiplication
        string divSym = "÷";     //Symbol for Division
        string addSym = "+";     //Symbol for Addition
        string subSym = "-";     //Symbol for Subtraction
        bool op_actv = false;
        public string n = "";  //used to make variables seperate
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
            op_actv = false;
        }
        private void addOutputscreen(string add_char)
        {
            output_screen.Text = output_screen.Text + add_char;
        }
        private void ops_Click(string num, string op)
        {
            if (op_actv == false)
            {
                if (ioScreen.Text != "" || n != "") //As to not make an error when ioScreen.Text is empty
                {
                    nth++;
                    PEMDAS.add_num(double.Parse(num));
                    PEMDAS.add_ops(op);
                    addOutputscreen(num + " " + op + " ");
                    n = "";
                    op_actv = true;
                }
            }                        
        }

        //Operation Events
        private void plus_Click(object sender, EventArgs e)
        {        
            ops_Click(n, addSym);                              
        }

        private void minus_Click(object sender, EventArgs e)
        {
            ops_Click(n, subSym);
        }

        private void div_Click(object sender, EventArgs e)
        {
            ops_Click(n, divSym);         
        }

        private void mult_Click(object sender, EventArgs e)
        {         
            ops_Click(n, multSym);          
        }

        //Other Events
        private void sqr_function_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "" && ioScreen.Text != "0")
            {
                n = PEMDAS.other_ops(n, "sqr");
                ioScreen.Text = String.Empty;
                ioScreen.Text += n;
            }        
        }

        


        private void reciprocal_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "" && ioScreen.Text != "0")
            {
                n = PEMDAS.other_ops(n, "reciprocal");
                ioScreen.Text = String.Empty;
                ioScreen.Text += n;
            }          
        }

        private void percent_Click(object sender, EventArgs e)
        {
            if (PEMDAS.nums.Count != 0)
            {
                n = PEMDAS.other_ops(n, "percent");
                ioScreen.Text = String.Empty;
                ioScreen.Text += n;
                equal.PerformClick();
            }               
        }

        private void sqrt_function_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "" && ioScreen.Text != "0")
            {
                n = PEMDAS.other_ops(n, "sqrt");
                ioScreen.Text = String.Empty;
                ioScreen.Text += n;
            }       
        }

        private void m_clear_Click(object sender, EventArgs e)
        {
            mem_page.Controls.Clear();
        }

        private void m_recall_Click(object sender, EventArgs e)
        {

        }

        private void m_add_Click(object sender, EventArgs e)
        {
            Memory panel_cont = new Memory();
            if (mem_page.Controls.Count > 0) 
            {
                mem_pageVal = double.Parse(n) + double.Parse(panelVal.Text);
                panelVal.Text = mem_pageVal.ToString();
            }
        }

        private void m_sub_Click(object sender, EventArgs e)
        {
            Memory panel_cont = new Memory();
            if (mem_page.Controls.Count > 0)
            {
                mem_pageVal = double.Parse(n) - double.Parse(panelVal.Text);
                panelVal.Text = mem_pageVal.ToString();
            }
        }

        private void m_store_Click(object sender, EventArgs e)
        {
            Memory mem_text = new Memory();
            mem_text.add_mem(this);
        }
        private void clear_Click(object sender, EventArgs e)
        {
            ioScreen.Text = String.Empty;;          
            n = "";
            op_actv = true;
        }
        private void clearE_Click(object sender, EventArgs e)
        {
            ioScreen.Text = String.Empty;
            output_screen.Text = String.Empty;
            PEMDAS.ops.Clear();
            PEMDAS.nums.Clear();
            n = "";
            op_actv = false;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            last_opIndex = PEMDAS.ops.Count();
            last_numsIndex = PEMDAS.nums.Count();
            while (true)
            {
                if (ioScreen.Text == "" || ioScreen.Text == "0") // 
                {
                    if (PEMDAS.nums.Count == 0)
                    {
                        break;
                    }
                }
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
                        op_actv = false;
                    }
                }


                if (last_opIndex < last_numsIndex) // so that the ops list count is the same as nums list count
                {
                    PEMDAS.nums.RemoveAt(last_numsIndex - 1);
                }
                break;
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
                output_screen.Text = String.Empty;
                n = "";
                op_actv = true; 
            }
            else
            {
                res = double.Parse(ioScreen.Text);
                hist_list.Text = "\n" + "\n= " + res + hist_list.Text;
                n = "";
            }       
        }

        //Button Events
        private void btn_dot_Click(object sender, EventArgs e)
        {          
            Add_text(".");
        }       

        private void btn0_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "0")
            {
                Add_text("0");
            }           
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
