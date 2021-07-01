using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class PEMDAS 
    {
        static double res;     //result
        static int init_count; //for checking what order an operator is
        static int dict_quan;  //Quantity of keys in dictionary
        static int nth = 0;    //nth key or nth operands
        static int nth_mult; //index of a multiplication symbol
        static int nth_div; //index of a division symbol
        static string multSym = "×";    //Symbol for multiplication
        static string divSym = "÷";     //Symbol for Division
        static string addSym = "+";     //Symbol for Addition
        static string subSym = "-";     //Symbol for subtraction
        public static List<double> nums = new List<double>(); //list for nth operand and its value
        public static List<string> ops = new List<string>(); //list for nth operators
        public static void add_num(double num)
        {
            nums.Add(num);
        }

        public static void add_ops(string op)
        {
            ops.Add(op);
        }       

        private static int dict_check() //dictionary count
        {
            dict_quan = nums.Count();
            return dict_quan;
        }
        
        public static void ops_Click(string num, string op)
        {
            nth++;
            PEMDAS.add_num(double.Parse(num));
            PEMDAS.add_ops(op);
            Form1 addoutput = new Form1();
            addoutput.addOutputscreen(num + " " + op + " ");
            addoutput.n = "";
        }

        private static void pemdas_logic(int nth, string operation)
        {
            res = 0;
            if (operation == multSym)
            {
                nth = ops_check(multSym);
                res = nums[nth] * nums[nth + 1];
            }
            else if (operation == divSym)
            {
                nth = ops_check(divSym);
                res = nums[nth] / nums[nth + 1];
            }
            else if (operation == addSym)
            {
                res = nums[0] + nums[0 + 1];
            }
            else if (operation == subSym)
            {
                res = nums[0] - nums[0 + 1];
            }
            nums.RemoveRange(nth, 2);
            ops.RemoveAt(nth);
            nums.Insert(nth, res);
        }

        public static int ops_check(string op) //Checks what index in the operation dictionary, is a multiplication or division
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
                for (int i = 0; i < init_count; i++)
                {
                    if (ops[i] == divSym)
                    {
                        return i;
                    }
                }
            }
            return 1;
        }

        public static bool ops_contains(string op) //Checks whether the operation is in the equation
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

        public static double equal_function(string n)
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
                    pemdas_logic(nth_mult, multSym);
                }
                else if (nth_div < nth_mult)
                {
                    pemdas_logic(nth_div, divSym);
                }
            }
            dict_quan = dict_check();
            nth = 0;
            for (int i = 0; i < dict_quan - 1; i++)
            {
                if (ops[0] == addSym)
                {
                    pemdas_logic(nth, addSym);
                }
                else if (ops[0] == subSym)
                {
                    pemdas_logic(nth, subSym);
                }
            }
            return res;
        }
    }
}
