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
        int init_count; //for checking what order an operator is
        int dict_quan;  //Quantity of keys in dictionary
        int nth = 0;    //nth key or nth operands
        int nth_mult; //index of a multiplication symbol
        int nth_div; //index of a division symbol
        int end_io;  //index of last character of ioScreen.Text      
        int end_n;   //index of last character of n
        int last_opIndex; //Used in backspace event, last ops index
        int last_numsIndex; //Used in backspace even, last ops index
        char idx_end_io_ch; //To convert into string later on
        string multSym = "×";    //Symbol for multiplication
        string divSym = "÷";     //Symbol for Division
        string addSym = "+";     //Symbol for Addition
        string subSym = "-";     //Symbol for subtraction
        string idx_end_io;
        string n = "";  //used to make variables seperate
        List<double> nums = new List<double>(); //list for nth operand and its value
        List<string> ops = new List<string>(); //list for nth operators
        List<string> texts = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        //Methods
        private int dict_check() //dictionary count
        {
            dict_quan = nums.Count();
            return dict_quan;
        }

        private int ops_check(string op) //Checks what index in the operation dictionary, is a multiplication or division
        {
            init_count = dict_check() - 1;
            if (op == multSym)
            {               
                for (int i = 0; i < init_count; i++)
                {
                    if (ops[i] == multSym)
                    {
                        return i;
                    }
                }
            }
            else if (op == divSym)
            {
                for (int i = 0 ; i < init_count; i++)
                {
                    if (ops[i] == divSym)
                    {
                        return i;
                    }
                }
            }
            return 1;
        }

        private bool ops_contains(string op) //Checks whether the operation is in the equation
        {
            init_count = dict_check() - 1;
            if (op == multSym)
            {
                for (int i = 0; i < init_count; i++)
                {
                    if (ops[i] == multSym)
                    {
                        return true;
                    }
                }             
            }
            else if (op == divSym)
            {
                for (int i = 0; i < init_count; i++)
                {
                    if (ops[i] == divSym)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void Add_text(string add_char)
        {
            n = n + add_char;
            ioScreen.Text = ioScreen.Text + add_char;
        }

        private void ioScreen_TextChanged(object sender, EventArgs e)
        {

        }

        //Operation Events
        private void plus_Click(object sender, EventArgs e)
        {

            if (ioScreen.Text != "" || n != "") //As to not make an error when ioScreen.Text is empty
            {    
                nth++;
                nums.Add(double.Parse(n));
                ops.Add("+");
                ioScreen.Text = ioScreen.Text + " + ";                  
                n = "";                  
            }               
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "" || n != "") //As to not make an error when ioScreen.Text is empty
            {
                nth++;
                nums.Add(double.Parse(n));
                ops.Add("-");
                ioScreen.Text = ioScreen.Text + " - ";
                n = "";
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "" || n != "") //As to not make an error when ioScreen.Text is empty
            {
                nth++;
                nums.Add(double.Parse(n));
                ops.Add(divSym);
                ioScreen.Text = ioScreen.Text + " ÷ ";
                n = "";
            }            
        }

        private void mult_Click(object sender, EventArgs e)
        {
            if (ioScreen.Text != "" || n != "") //As to not make an error when ioScreen.Text is empty
            {
                nth++;
                nums.Add(double.Parse(n));
                ops.Add(multSym);
                ioScreen.Text = ioScreen.Text + " × ";
                n = "";
            }
        }
       
        //Other Events
        private void clear_Click(object sender, EventArgs e)
        {
            ioScreen.Text = String.Empty;
            res = 0;
            ops.Clear();
            nums.Clear();
            n = "0";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            end_io = ioScreen.Text.Length;
            end_n = n.Length;
            last_opIndex = ops.Count();
            last_numsIndex = nums.Count;

            if (ioScreen.Text == "")
            {
                n = "0";
                res = 0;
                ops.Clear();
                nums.Clear();
            }
            if (ioScreen.Text.Length >= 1)
            {               
                idx_end_io_ch = ioScreen.Text[end_io - 1];
                idx_end_io = idx_end_io_ch.ToString();
                ioScreen.Text = ioScreen.Text.Remove(end_io - 1, 1);                            
            }
            
            if (idx_end_io == multSym || idx_end_io == divSym || idx_end_io == addSym || idx_end_io == subSym)
            {             
                ops.RemoveAt(last_opIndex - 1);
            }

            if (last_opIndex < last_numsIndex)
            {
                nums.RemoveAt(last_numsIndex - 1);
            }

            if (n.Length >= 1)
            {
                n = n.Remove(end_n - 1, 1);
            }
        }
        private void neg_Click(object sender, EventArgs e)
        {        
            if (n.Contains("-") == false)
            {
                ioScreen.Text = "-" + ioScreen.Text;
                n = "-" + n;
            }
        }

        private void ans_Click(object sender, EventArgs e)
        {
            ioScreen.Text = ioScreen.Text + "ans";
            n = prev_res.ToString();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (n != "")
            {
                nth++;
                nums.Add(double.Parse(n));
            }
            while (ops_contains(multSym) == true || ops_contains(divSym) == true)
            {
                nth_mult = ops_check(multSym);
                nth_div = ops_check(divSym);
                if (ops_contains(multSym) == false)
                {
                    nth_div = nth_mult - 1;
                }
                else if (ops_contains(divSym) == false)
                {
                    nth_mult = nth_div - 1;
                }
                if (nth_mult < nth_div)
                {
                    nth_mult = ops_check(multSym);
                    res = 0;
                    res = nums[nth_mult] * nums[nth_mult + 1];
                    nums.RemoveRange(nth_mult, 2);
                    ops.RemoveAt(nth_mult);
                    nums.Insert(nth_mult, res);                 
                }                
                else if (nth_div < nth_mult)
                {
                    nth_div = ops_check(divSym);
                    res = 0;
                    res = nums[nth_div] / nums[nth_div + 1];
                    nums.RemoveRange(nth_div, 2);
                    ops.RemoveAt(nth_div);
                    nums.Insert(nth_div, res);
                }
            }
            dict_quan = dict_check();
            nth = 0;
            for (int i = 0; i < dict_quan-1; i++)
            {
                if (ops[0] == addSym)
                {
                    res = 0;
                    res = nums[0] + nums[0 + 1];
                    nums.RemoveRange(nth, 2);
                    ops.RemoveAt(nth);
                    nums.Insert(nth, res);             
                }
                else if (ops[0] == subSym)
                {
                    res = 0;
                    res = nums[0] - nums[0 + 1];
                    nums.RemoveRange(nth, 2);
                    ops.RemoveAt(nth);
                    nums.Insert(nth, res);
                }
            }
            ioScreen.Text = res.ToString();
            prev_res = res;
            ops.Clear();
            nums.Clear();
            nums.Add(res);
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
           
        }

        private void sqr_function_Click(object sender, EventArgs e)
        {

        }
    }
}
