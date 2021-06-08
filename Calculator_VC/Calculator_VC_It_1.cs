using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_VC
{
    class Calculator_VC_It_1
    {
        // User Story "Add": - User wants to see sum of two digits that he enters
        //                   - Any two integers can be added up correctly
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first summand: ");
            Int64 dc_1st = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Please enter the second summand: ");
            Int64 dc_2nd = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(Convert.ToString(dc_1st) + " + " + Convert.ToString(dc_2nd) + " = " + Convert.ToString((dc_1st + dc_2nd)));

            Console.ReadKey();
        }
    }
}
