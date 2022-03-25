using System;

namespace Ladder
{
    class Ladder
    {
        internal static string Build(uint input)
        {
            string answer = "";
            for (uint i = 1; i <= input; i++)
            {
                for (uint j = 0; j < i; j++)
                {
                    answer +='*';
                }
                answer += '\n';
            }

            answer += '\n';
            if (input % 2 == 0) { input++; }

            for (uint i = 0; i<= input/2; i++)
            {
                for (uint j = 0; j < input/2-i; j++)
                {
                    answer += ' ';
                }
                for (uint j = 1; j <= i*2+1; j++)
                {
                    answer += '*';
                }
                answer += '\n';
            }
            return answer;
        }
    }
}
