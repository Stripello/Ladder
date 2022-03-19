using System;

namespace Ladder
{
    class Outputer
    {
        internal static void Output(uint input)
        {
            
            for (uint i = 1; i <= input; i++)
            {
                for (uint j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }

            Console.Write('\n');
            if (input % 2 == 0) { input++; }

            for (uint i = 0; i<= input/2; i++)
            {
                for (uint j = 0; j < input/2-i; j++)
                {
                    Console.Write(' ');
                }
                for (uint j = 1; j <= i*2+1; j++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');
            }
        }
    }
}
