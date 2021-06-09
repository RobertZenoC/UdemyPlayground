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
        // -----------
        // User Story "Substraction": User wants to be able to do substractions as well
        // Acceptance Criteria: A number with or without decimal places gets substracted correctly from another number with or without decimal places
        // User Story "Software Structure": Developer wants to structure the source code so that it will be easier to implement additional functions
        // Acceptance Criteria: The principle of single level of abstraction is applied and if not, the exception is justified and documented
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first summand: ");
            double d_1st = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second summand: ");
            double d_2nd = Convert.ToDouble(Console.ReadLine());

            // Calculate sum
            double d_sum = Add(d_1st, d_2nd);

            Console.WriteLine(Convert.ToString(d_1st) + " + " + Convert.ToString(d_2nd) + " = " + Convert.ToString(d_sum));

            WaitForUserInput();
        }

        static double Add(double d_1st, double d_2nd)
        {
            double d_sum = d_1st + d_2nd;

            return d_sum;
        }

        static void WaitForUserInput()
        {
            Console.WriteLine("(Press <CR> to quit)");
            Console.ReadLine();
        }
    }
}
