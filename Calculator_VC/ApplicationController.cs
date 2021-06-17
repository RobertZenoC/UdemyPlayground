using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_VC
{
    class ApplicationController
    {
        private ConsoleView consoleView;
        private CalculatorModel model;

        public ApplicationController(ConsoleView ConsoleView, CalculatorModel Model)
        {
            this.consoleView = ConsoleView;
            this.model = Model;
        }

        public void DoIt()
        {
            while (consoleView.b_Quit == false)
            {
                consoleView.GetUserInputCalculation();

                if (consoleView.b_EmptyRun == false)
                {
                    // Calculation
                    switch (model.s_Operator)
                    {
                        case "+":
                        case "-":
                            // ## Get result:
                            // Use method Calculate of object
                            model.Calculate();

                            // Result is the property d_Result of the object
                            consoleView.DisplayResult();
                            break;

                        case "/":
                        case "*":
                            // ## Get result:
                            // Use method Calculate of object
                            model.Calculate();

                            // Result is the property d_Result of the object
                            consoleView.DisplayResult();
                            // Reset the 1stRun switch, so that an entirely new calculation starts
                            consoleView.b_1stRun = true;
                            break;

                        case "quit":
                            break;
                        default:
                            // Reset the 1stRun switch, so that an entirely new calculation starts
                            consoleView.b_1stRun = true;

                            consoleView.DisplayInvalidOperator(model.s_Operator);
                            break;
                    }
                }
                else
                {
                    consoleView.b_EmptyRun = false;
                }
            }

            if (consoleView.b_Quit == false)
            {
                consoleView.WaitForQuit();
            }
        }
    }
}
