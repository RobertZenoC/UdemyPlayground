using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caclulator_It_D002
{
    class Calculator_002
    {
        static void Main(string[] args)
        // User Story "Handling": - User wants to enter the numbers separated by a blank and start processing with<CR>
        {
            // ### Declare the variables used for taking up input and for calculation
            string st_input;
            int i_posBlank;
            Int64 i64_1st;
            Int64 i64_2nd;

            Console.WriteLine("Please enter the two numbers you want to add, separated by a blank: ");
            st_input =Console.ReadLine();

            i_posBlank = st_input.IndexOf(" ");

            i64_1st = Convert.ToInt64(st_input.Substring(0, (i_posBlank)));

            i64_2nd = Convert.ToInt64(st_input.Substring((i_posBlank + 1), (st_input.Length - (i_posBlank+1))));

            Console.WriteLine(Convert.ToString(i64_1st) + " + " + Convert.ToString(i64_2nd) + " = " + Convert.ToString((i64_1st + i64_2nd)));

            Console.ReadKey();
        }
    }
}
