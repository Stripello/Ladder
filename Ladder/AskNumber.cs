using System;

namespace Ladder
{
    internal static class AskNumbers
    {
        internal static uint? Ask()
        {
            uint answer;
            string userAnswer;
           
            do
            {
                Console.WriteLine("Enter number to create \"сhristmass tree\" or type \"Exit\" " +
                    "to terminate process.");
                userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == "exit")
                {
                    return null;
                }
                if (uint.TryParse(userAnswer, out answer))
                {
                    break;
                }
                Console.WriteLine("Can't parse entered string.");
            }
            while (true);

            return answer;
        }
    }
}