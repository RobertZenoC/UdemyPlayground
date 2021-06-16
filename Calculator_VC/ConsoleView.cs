using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_VC
{
    class ConsoleView
    {
        // Attributes
        private CalculatorModel model;

        // Properties
        public string s_Input { get; private set; }

        // Constructor
        public ConsoleView(CalculatorModel Model)
        {
            this.model = Model;
            s_Input = "";
        }

        public void GetUserInput(string s_prompt)
        {
            if (s_prompt != "")
            {
                DisplayPrompt(s_prompt);
            }

            string s_input = Console.ReadLine();

            s_Input = s_input;
        }

        public void GetNumber()
        {
            DisplayPrompt("Please enter a number: ");

            string s_input = Console.ReadLine();

            s_Input = s_input;
        }

        public void GetOperator()
        {
            DisplayPrompt("Please enter the operator ('+', '-', '*' or '/': ");

            string s_input = Console.ReadLine();

            s_Input = s_input;
        }

        public void WaitForQuit()
        {
            DisplayPrompt("(Press <CR> to quit)");

            Console.ReadLine();
        }

        public void DisplayPrompt(string s_prompt)
        {
            Console.WriteLine(s_prompt);
        }

        public void DisplayResult()
        {
            string s_resultName = "";

            // Find proper name for result
            switch (model.s_Operator)
            {
                case "+":
                    s_resultName = "sum";
                    break;
                case "-":
                    s_resultName = "difference";
                    break;
                case "/":
                    s_resultName = "fraction";
                    break;
                case "*":
                    s_resultName = "product";
                    break;
                default:
                    break;
            }

            Console.WriteLine("The " + s_resultName + " is: " + model.d_Result);
        }
        public void DisplayInvalidOperator(string s_operator)
        {
            Console.WriteLine("Invalid operator: " + s_operator);
        }


    }
}
