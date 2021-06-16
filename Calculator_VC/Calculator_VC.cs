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
        //
        // User Story "Software Structure": Developer wants to structure the source code so that it will be easier to implement additional functions
        // Acceptance Criteria: The principle of single level of abstraction is applied and if not, the exception is justified and documented

        // Iteration III
        // -------------
        // User Story "Multiplication, division": User wants to be able to do multiplications and divisions as well
        // Acceptance Criteria: Multiplications and divisions get done correctly with any numbers with or without decimal places
        //
        // User Story "Software Structure": Developer wants to have an own method for the calculation as well as for presenting the result
        // Acceptance Criteria: The principle of single level of abstraction is applied and if not, the exception is justified and documented

        // Iteration IV
        // -------------
        // User Story "Object oriented": Developer wants to work with objects, so that additional functions may more easily be implemented
        // Acceptance Criteria: Distribution of functionalities between classes adhers to the principal 'Separation of Concerns' (SoC)
        //                      and 'Don't repeat yourself' (DRY)
        //                      (after all, everyone likes DRY SoCs, don't they?)
        // REMARK: This story is actually an extension of "Software Structure"
        //
        // User Story "Continuous Calculation": For additions and substractions, user wants to be able to throw in a third number, and a fourth, and...
        // Acceptance Criteria: - For the additional calculations, the same operation gets carried out as with the first one
        //                      - New result gets displayed without further interaction of the user

        static void Main(string[] args)
        {
            // Initialize objects on classes
            CalculatorModel model = new CalculatorModel();
            ConsoleView consoleView = new ConsoleView(model);

            consoleView.GetNumber();
            string s_1st = consoleView.s_Input;

            consoleView.GetOperator();
            string s_operator = consoleView.s_Input;

            consoleView.GetNumber();
            string s_2nd = consoleView.s_Input;

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
                    // ## Get result:
                    // Use method Calculate of object
                    model.Calculate(d_1st, d_2nd, s_operator);

                    // Result is the property d_Result of the object
                    consoleView.DisplayResult();
                    break;

                default:
                    consoleView.DisplayInvalidOperator(s_operator);
                    break;
            }

            consoleView.WaitForQuit();
        }

    }
}
