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
            double d_1st = consoleView.GetNumber();

            string s_operator = consoleView.GetOperator();

            double d_2nd = consoleView.GetNumber();

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
