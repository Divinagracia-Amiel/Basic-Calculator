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
        public static int dict_check() //dictionary count
        {
            dict_quan = nums.Count();
            return dict_quan;
        }

        private static void ops_logic(int nth, string ops)
        {
            if (ops == multSym)
            {

            }
            else if (ops == divSym)
            {

            }
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
            for (int i = 0; i < dict_quan - 1; i++)
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
            return res;
        }
    }
}
