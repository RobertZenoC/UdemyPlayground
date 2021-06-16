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
                        consoleView.b_1stRun = true;
                        break;

                    case "quit":
                        break;
                    default:
                        consoleView.DisplayInvalidOperator(model.s_Operator);
                        break;
                }
            }

            if (consoleView.b_Quit == false)
            {
                consoleView.WaitForQuit();
            }
        }
    }
}
