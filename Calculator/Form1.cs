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
        List<string> texts = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        //Methods       
       

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
                PEMDAS.add_num(double.Parse(n));
                PEMDAS.add_ops("+");
                ioScreen.Text = ioScreen.Text + " + ";                  
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
                ioScreen.Text = ioScreen.Text + " - ";
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
                ioScreen.Text = ioScreen.Text + " ÷ ";
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
                ioScreen.Text = ioScreen.Text + " × ";
                n = "";
            }
        }
       
        //Other Events
        private void clear_Click(object sender, EventArgs e)
        {
            ioScreen.Text = String.Empty;
            res = 0;
            PEMDAS.ops.Clear();
            PEMDAS.nums.Clear();
            n = "0";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            end_io = ioScreen.Text.Length;
            end_n = n.Length;
            last_opIndex = PEMDAS.ops.Count();
            last_numsIndex = PEMDAS.nums.Count();

            if (ioScreen.Text == "")
            {
                n = "0";
                res = 0;
                PEMDAS.ops.Clear();
                PEMDAS.nums.Clear();
            }
            if (ioScreen.Text.Length >= 1)
            {               
                idx_end_io_ch = ioScreen.Text[end_io - 1];
                idx_end_io = idx_end_io_ch.ToString();
                ioScreen.Text = ioScreen.Text.Remove(end_io - 1, 1);                            
            }
            
            if (idx_end_io == multSym || idx_end_io == divSym || idx_end_io == addSym || idx_end_io == subSym)
            {             
                PEMDAS.ops.RemoveAt(last_opIndex - 1);
            }

            if (last_opIndex < last_numsIndex)
            {
                PEMDAS.nums.RemoveAt(last_numsIndex - 1);
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
            res = PEMDAS.equal_function(n);
            hist_list.Text = "\n" + ioScreen.Text + "\n= " + res.ToString() + "\n" + hist_list.Text;
            ioScreen.Text = res.ToString();
            prev_res = res;
            PEMDAS.ops.Clear();
            PEMDAS.nums.Clear();
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
            hist_list.SelectAll();
            hist_list.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void sqr_function_Click(object sender, EventArgs e)
        {

        }

    }
}
