using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_VC
{
    class Calculator_VC
    {
        // Iteration I
        // -----------
        // User Story "Add": User wants to see sum of two digits that he enters
        // User Story "Decimals": User wants to be able to work with decimal places
        // Acceptance Criteria: Two numbers with or without decimal places get added correctly

        // Iteration II
        // ------------
        // User Story "Substraction": User wants to be able to do substractions as well
        // Acceptance Criteria: A number with or without decimal places gets substracted correctly from another number with or without decimal places
        // User Story "Software Structure": Developer wants to structure the source code so that it will be easier to implement additional functions
        // Acceptance Criteria: The principle of single level of abstraction is applied and if not, the exception is justified and documented

        // Iteration III
        // -------------
        // User Story "Multiplication, division": User wants to be able to do multiplications and divisions as well
        // Acceptance Criteria: Multiplications and divisions get done correctly with any numbers with or without decimal places
        // User Story "Software Structure": Developer wants to have an own method for the calculation as well as for presenting the result
        // Acceptance Criteria: The principle of single level of abstraction is applied and if not, the exception is justified and documented

        static void Main(string[] args)
        {
            
            string s_1st = GetUserInput("Please enter the first number: ");
            string s_2nd = GetUserInput("Please enter the second number: ");
            string s_operator = GetUserInput("Please enter the operator ('+', '-', '*' or '/': ");

            // Convert user input from string to double
            // TODO: Move to own method, once the structure gets more complex
            double d_1st = Convert.ToDouble(s_1st);
            double d_2nd = Convert.ToDouble(s_2nd);

            // Calculation
            switch (s_operator)
            {
                case "+":
                case "-":
                case "/":
                case "*":
                    // Present result
                    PresentResult(d_1st, d_2nd, s_operator, Calculate(d_1st, d_2nd, s_operator));
                    break;

                default:
                    Console.WriteLine("Invalid operator: {0}", s_operator);
                    break;
            }

            GetUserInput("(Press <CR> to quit)");
        }

        static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string s_input = Console.ReadLine();

            return s_input;
        }

        static void PresentResult(double d_1st, double d_2nd, string s_operator, double d_result)
        {
            Console.WriteLine("{0} {1} {2} = {3}", d_1st, s_operator, d_2nd, d_result);
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
    }
}
