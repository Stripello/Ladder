using System;

namespace Ladder

{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter number to create \"сhristmass tree\" or type \"Exit\" to terminate process.");
                string input = Console.ReadLine();
                if (input.ToLower().Equals("exit")) return;
                bool succedParsing = uint.TryParse(input, out uint inputNumber);
                if (succedParsing) { Outputer.Output(inputNumber); }
                else { Console.WriteLine("Can't parse input string."); }
            }
        }
    }
}
