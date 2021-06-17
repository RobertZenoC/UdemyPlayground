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

        // Variables
        private double d_number;
        private bool b_validNumber;
        private int i_rangeCheck;
        private string s_promptOoRange;

        public void GetUserInputCalculation()
        {
            // Used for message when the number checked exceeds the limit
            s_promptOoRange = "please choose a value between " + model.d_LowLimit + " and " + model.d_HighLimit;

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
            d_number = 0;

            DisplayPrompt("Please enter a number (or 'quit' to quit): ");

            string s_input = Console.ReadLine();

            if (s_input == "quit")
            {
                b_Quit = true;
            }
            else
            {
                // Check the input
                b_validNumber = false;

                while (b_validNumber == false)
                {
                    // Is it numeric?
                    if (!Double.TryParse(s_input, out d_number))
                    {
                        Console.WriteLine("'" + s_input + "' is not a valid floating point number - please try again (or 'quit' to quit):");
                    }
                    else
                    {
                        i_rangeCheck = model.CheckRange(d_number);

                        switch (i_rangeCheck)
                        {
                            case -1:
                                Console.WriteLine("'" + d_number + "' is too low - " + s_promptOoRange);
                                break;
                            case 1:
                                Console.WriteLine("'" + d_number + "' is too high - " + s_promptOoRange);
                                break;
                            default:
                                b_validNumber = true;
                                break;
                        }
                    }

                    if (b_validNumber == false)
                    {
                        s_input = Console.ReadLine();

                        if (s_input == "quit")
                        {
                            b_Quit = true;

                            // A bit of a lie here - but it's necessary to leave the loop
                            b_validNumber = true;
                        }
                    }
                }
            }
            return d_number;
        }

        private double GetAnotherNumber()
        {
            d_number = 0;
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
                // Check the input
                b_validNumber = false;

                while (b_validNumber == false)
                {
                    // Is it numeric?
                    if (!Double.TryParse(s_input, out d_number))
                    {
                        Console.WriteLine("'" + s_input + "' is not a valid floating point number - please try again (or 'quit' to quit):");
                    }
                    else
                    {
                        i_rangeCheck = model.CheckRange(d_number);

                        switch (i_rangeCheck)
                        {
                            case -1:
                                Console.WriteLine("'" + d_number + "' is too low - " + s_promptOoRange);
                                break;
                            case 1:
                                Console.WriteLine("'" + d_number + "' is too high - " + s_promptOoRange);
                                break;
                            default:
                                b_validNumber = true;
                                break;
                        }
                    }

                    if (b_validNumber == false)
                    {
                        s_input = Console.ReadLine();

                        if (s_input == "quit")
                        {
                            b_Quit = true;

                            // A bit of a lie here - but it's necessary to leave the loop
                            b_validNumber = true;
                        }
                        else if (s_input == "new")
                        // Quit the ongoing calculation and start a new one
                        {
                            b_1stRun = true;
                            b_EmptyRun = true;

                            // A bit of a lie here - but it's necessary to leave the loop
                            b_validNumber = true;
                        }
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
