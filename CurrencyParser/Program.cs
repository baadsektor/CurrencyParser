using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the currency parser.");

            bool shouldContinue = true;

            while(shouldContinue)
            {
                Console.WriteLine("\nPlease enter a number between 0,01 and 999 999 999 or type 'exit' to leave this application:\n");
                string input = Console.ReadLine();
                if (input.Equals("exit"))
                {
                    shouldContinue = false;
                    return;
                }

                InputProcessor inputProcessor = new InputProcessor(new InputValidator());
                inputProcessor.ProcessInput(input);
            }
        }
    }
}
