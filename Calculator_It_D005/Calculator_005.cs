using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_It_D005
{
    class Calculator_005
    {
        static void Main(string[] args)
        // User Story "Handling": - User wants the program to be ready for the next input after displaying the result
        // Acceptance: <CR> must start processing when there's input and close the program, when there's no new input
        {
            // ### Declare the variables used for taking up input and for calculation
            string s_operator;
            string s_input;
            Int32 i32_posOperator;
            string s_1st;
            string s_2nd;
            double d_1st;
            double d_2nd;

            s_input = GetUserInput("Please enter your calculation in the format [number 1][operator][number 2] (operators allowed: +, -, *, /)");

            while (s_input.Length > 0)
            {
                // find position of operator (if there is no valid operator, position is -1)
                i32_posOperator = GetPosOperator(s_input);

                if (i32_posOperator == -1)
                {
                    GetUserInput("No valid operator found in '" + s_input + "' (press <CR> to terminate)");
                    return;
                }

                // get the operator
                s_operator = GetCharAtPos(s_input, i32_posOperator);

                // get first number as string
                s_1st = GetCharBeforePos(s_input, i32_posOperator);

                // get second number as a string
                s_2nd = GetCharAfterPos(s_input, i32_posOperator);

                // convert numbers to doubles
                d_1st = Convert.ToDouble(s_1st.Trim(' '));
                d_2nd = Convert.ToDouble(s_2nd.Trim(' '));

                //Console.WriteLine("{0}{1}{2}", d_1st, st_operator, d_2nd);
                //Console.ReadLine();
                //return;

                if (DivideByZero(s_operator, d_2nd) == true)
                {
                    GetUserInput("Does not compute '" + s_input + "' - Division by zero not allowed (press <CR> to terminate)");
                    return;
                }

                // Present result
                PresentResult(d_1st, d_2nd, s_operator, Calculate(d_1st, d_2nd, s_operator));

                // get new input
                s_input = GetUserInput("");
            }

        }

        static string GetUserInput(string s_prompt)
        {
            if (s_prompt != "")
            {
                Console.WriteLine(s_prompt);

            }
            string s_input = Console.ReadLine();

            return s_input;
        }


        static Int32 GetPosOperator(string s_input)
            // Returns the position of the operator or -1, if non of the operators for the basic operations is found
        {
            Int32 i32_posOperator = 0;

            if (s_input.Length > 0)
            {
                // find position of operator...
                i32_posOperator = s_input.IndexOf("+");

                if (i32_posOperator == -1)
                {
                    i32_posOperator = s_input.IndexOf("-");
                    if (i32_posOperator == -1)
                    {
                        i32_posOperator = s_input.IndexOf("*");
                        if (i32_posOperator == -1)
                        {
                            i32_posOperator = s_input.IndexOf("/");
                        }
                    }
                }
            }
            return i32_posOperator;
            ;
        }
        
        static string GetCharAtPos(string s_string, Int32 i32_pos)
        {
            return s_string.Substring(i32_pos, 1);
        }

        static string GetCharBeforePos(string s_string, Int32 i32_pos)
        {
            return s_string.Substring(0, (i32_pos));
        }

        static string GetCharAfterPos(string s_string, Int32 i32_pos)
        {
            return s_string.Substring((i32_pos + 1), (s_string.Length - (i32_pos + 1)));
        }

        static double Calculate(double d_1st, double d_2nd, string s_operator)
        {
            double d_result = 0;

            switch (s_operator)
            {
                case "+":
                    d_result = Add(d_1st, d_2nd);
                    break;

                case "-":
                    d_result = Substract(d_1st, d_2nd);
                    break;

                case "*":
                    d_result = Multiply(d_1st, d_2nd);
                    break;

                case "/":
                    d_result = Divide(d_1st, d_2nd);
                    break;

                default:
                    break;
            }

            return d_result;
        }

        static double Add(double d_1st, double d_2nd)
        {
            double d_sum = d_1st + d_2nd;

            return d_sum;
        }

        static double Substract(double d_minuend, double d_subtrahend)
        {
            double d_difference = d_minuend - d_subtrahend;

            return d_difference;
        }

        static double Multiply(double d_multiplier, double d_multiplicand)
        {
            double d_product = d_multiplier * d_multiplicand;

            return d_product;
        }

        static double Divide(double d_dividend, double d_divisor)
        {
            double d_fraction = d_dividend / d_divisor;

            return d_fraction;
        }
        static void PresentResult(double d_1st, double d_2nd, string s_operator, double d_result)
        {
            Console.WriteLine("{0} {1} {2} = {3}", d_1st, s_operator, d_2nd, d_result);
        }
        static bool DivideByZero(string s_operator, double d_divisor)
        {
            // if the operation is a division, check for devides by 0
            if (s_operator == "/")
            {
                if (d_divisor == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}