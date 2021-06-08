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
            string st_operator;
            string st_input;
            int i_posBlank;
            Int64 i64_1st;
            Int64 i64_2nd;
            Int64 i64_result = 0;

            Console.WriteLine("Please enter your calculation in the format [number 1][operator][number 2] (operators allowed: +, -, *, /)");
            st_input = Console.ReadLine();

            while (st_input.Length > 0)
            {
                // find position of operator...
                i_posBlank = st_input.IndexOf("+");

                if (i_posBlank == -1)
                {
                    i_posBlank = st_input.IndexOf("-");
                    if (i_posBlank == -1)
                    {
                        i_posBlank = st_input.IndexOf("*");
                        if (i_posBlank == -1)
                        {
                            i_posBlank = st_input.IndexOf("/");
                            if (i_posBlank == -1)
                            {
                                Console.WriteLine("Invalid operator - processing terminated");
                                Console.ReadKey();
                                return;
                            }
                        }
                    }
                }

                // extract operator from string
                st_operator = st_input.Substring((i_posBlank), 1);

                i64_1st = Convert.ToInt64(st_input.Substring(0, (i_posBlank)));

                i64_2nd = Convert.ToInt64(st_input.Substring((i_posBlank + 1), (st_input.Length - (i_posBlank + 1))));

                switch (st_operator)
                {
                    case "+":
                        i64_result = (i64_1st + i64_2nd);
                        break;
                    case "-":
                        i64_result = (i64_1st - i64_2nd);
                        break;
                    case "*":
                        i64_result = (i64_1st * i64_2nd);
                        break;
                    case "/":
                        if (i64_2nd == 0)
                        {
                            Console.WriteLine(Convert.ToString(i64_1st) + " " + st_operator + " " + Convert.ToString(i64_2nd) + " - Division by 0 does not compute!");
                        }
                        else
                        {
                            i64_result = (i64_1st / i64_2nd);
                        }
                        break;
                }

                if (i64_2nd != 0)
                {
                    Console.WriteLine(Convert.ToString(i64_1st) + " " + st_operator + " " + Convert.ToString(i64_2nd) + " = " + Convert.ToString(i64_result));
                }

                st_input = Console.ReadLine();
            }
        }
    }
}
