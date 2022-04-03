using System;

namespace Ladder

{
    class Program
    {
        static void Main()
        {
            var request = AskNumbers.Ask();
            if (request == null)
            {
                return;
            }

            Console.WriteLine(Ladder.Build((uint)request));
        }
    }
}
