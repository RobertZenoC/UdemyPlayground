using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_VC
{
    class ConsoleView
    {
        // Properties
        public string s_Input { get; private set; }

        // Constructor
        public ConsoleView()
        {
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

        public void DisplayPrompt(string s_prompt)
        {
            Console.WriteLine(s_prompt);
        }

    }
}
