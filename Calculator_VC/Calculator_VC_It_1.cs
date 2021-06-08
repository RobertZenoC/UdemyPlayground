using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_VC
{
    class Calculator_VC_It_1
    {
        // User Story "Add": User wants to see sum of two digits that he enters
        // User Story: "Decimals": User wants to be able to work with decimal places
        // Acceptance Criteria: Two numbers with or without decimal places get added correctly
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first summand: ");
            double d_1st = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second summand: ");
            double d_2nd = Convert.ToDouble(Console.ReadLine());

            // Calculate sum
            double d_sum = d_1st + d_2nd;

            Console.WriteLine(Convert.ToString(d_1st) + " + " + Convert.ToString(d_2nd) + " = " + Convert.ToString(d_sum));

            Console.ReadKey();
        }
    }
}
