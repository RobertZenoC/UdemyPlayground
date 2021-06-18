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
        // ------------
        // User Story "Object oriented": Developer wants to work with objects, so that additional functions may more easily be implemented
        // Acceptance Criteria: Distribution of functionalities between classes adhers to the principal 'Separation of Concerns' (SoC)
        //                      and 'Don't repeat yourself' (DRY)
        //                      (after all, everyone likes DRY SoCs, don't they?)
        // REMARK: This story is actually an extension of "Software Structure"
        //
        // User Story "Continuous Calculation": For additions and substractions, user wants to be able to throw in a third number, and a fourth, and...
        // Acceptance Criteria: - For the additional calculations, the same operation gets carried out as with the first one
        //                      - New result gets displayed without further interaction of the user

        // Iteration V
        // -----------
        // User Story "Stability": - User wants to be able to correct invalid numbers right after having entered them instead of having the program crash
        // User Story "Comfort": - User wants the program to recognize the control commands 'quit' and 'new' regardless of them being in capitals 
        //                         or lower case letters or any mixture of that
        //                       - User wants to get a message right after having entered an invalid operator and be able to correct it
        // User Story "Correct Calculation": User wants to get a warning when trying to devide by zero instead of a wrong result (8, for some reason...)
        // User Story "Range": Developer wants to be able to set upper and lower limits for the numbers that can be entered
        // Acceptance Criteria: - Upper- and lower limit for numbers entered by the user can be set on every instance of the class CalculatorModel
        //                      - Any error, such as non-numerical entries for numbers, numbers that are out of the range, invalid operators and 0 as a divisor
        //                        gets prompted to the user right away and the user can correct the wrong entry
        //                      - Processing of 'quit' and 'new' is not caps sensitive

        static void Main(string[] args)
        {

            // Initialize objects on classes
            CalculatorModel model = new CalculatorModel();

            // Set range for calculations
            model.d_LowLimit = -100;
            model.d_HighLimit = 1000;
            ConsoleView consoleView = new ConsoleView(model);
            ApplicationController controller = new ApplicationController(consoleView, model);

            controller.DoIt();
        }
    }
}
