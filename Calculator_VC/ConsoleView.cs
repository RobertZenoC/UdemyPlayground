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
        public bool b_Quit { get; private set; }
        public bool b_1stRun { get; set; }
        public bool b_EmptyRun { get; set; }

        // Constructor
        public ConsoleView(CalculatorModel Model)
        {
            this.model = Model;
            s_Input = "";
            b_Quit = false;
            b_1stRun = true;
            b_EmptyRun = false;
        }

        public void GetUserInputCalculation()
        {
            if (b_1stRun == true)
            {
                model.d_1st = GetNumber();

                if (b_Quit == false)
                {
                    model.s_Operator = GetOperator();
                    model.d_2nd = GetNumber();
                }
                b_1stRun = false;
            }
            else
            {
                model.d_1st = model.d_Result;
                model.d_2nd = GetAnotherNumber();
            }
        }
        private double GetNumber()
        {
            double d_number = 0;

            DisplayPrompt("Please enter a number (or 'quit' to quit): ");

            string s_input = Console.ReadLine();

            if (s_input == "quit")
            {
                b_Quit = true;
            }
            else
            {
                while (!Double.TryParse(s_input, out d_number))
                {
                    Console.WriteLine(s_input + " is not a valid floating point number - please try again (or 'quit' to quit):");

                    s_input = Console.ReadLine();

                    if (s_input == "quit")
                    {
                        b_Quit = true;

                        // Just that the TryParse is finally satisfied
                        s_input = "0";
                    }
                }
            }
            return d_number;
        }

        private double GetAnotherNumber()
        {
            double d_number = 0;
            string s_prompt = "Please enter another number to ";
            if (model.s_Operator == "+")
            {
                s_prompt = s_prompt + "add";
            }
            else
            {
                s_prompt = s_prompt + "susbtract";
            }

            DisplayPrompt(s_prompt + " (or 'new' to start a new calculation or 'quit' to quit): ");

            string s_input = Console.ReadLine();

            if (s_input == "quit")
             // Quit the whole calculator
            {
                b_Quit = true;
            }
            else if (s_input == "new")
            // Quit the ongoing calculation and start a new one
            {
                b_1stRun = true;
                b_EmptyRun = true;
            }
            else
            {
                while (!Double.TryParse(s_input, out d_number))
                {
                    Console.WriteLine("'" + s_input + "' is not a valid floating point number - please try again (or 'new' to start a new calculation or 'quit' to quit):");

                    s_input = Console.ReadLine();

                    if (s_input == "quit")
                    {
                        // Quit the whole calculator
                        b_Quit = true;

                        // Just that the TryParse is finally satisfied
                        s_input = "0";
                    }
                    else if (s_input == "new")
                    // Quit the ongoing calculation and start a new one
                    {
                        b_1stRun = true;
                        b_EmptyRun = true;

                        // Just that the TryParse is finally satisfied
                        s_input = "0";
                    }
                }
            }
            return d_number;
        }
        private string GetOperator()
        {
            DisplayPrompt("Please enter the operator ('+', '-', '*' or '/'): ");

            return Console.ReadLine();
        }

        public void WaitForQuit()
        {
            DisplayPrompt("(Press <CR> to quit)");

            Console.ReadLine();
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

        public void GetUserInput(string s_prompt)
        {
            if (s_prompt != "")
            {
                DisplayPrompt(s_prompt);
            }

            string s_input = Console.ReadLine();

            s_Input = s_input;
        }
        public void DisplayPrompt(string s_prompt)
        {
            Console.WriteLine(s_prompt);
        }
    }
}
