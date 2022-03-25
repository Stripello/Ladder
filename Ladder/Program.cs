using System;

namespace Ladder

{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter number to create \"сhristmass tree\" or type \"Exit\" " +
                    "to terminate process.");
                var input = Console.ReadLine();
                if (input.ToLower().Equals("exit"))
                {
                    return;
                }

                var succedParsing = uint.TryParse(input, out uint inputNumber);
                if (succedParsing) 
                {
                    Console.WriteLine(Ladder.Build(inputNumber)); 
                }
                else 
                { 
                    Console.WriteLine("Can't parse input string."); 
                }
            }
        }
    }
}
