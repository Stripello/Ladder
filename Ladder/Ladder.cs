using System.Text;

namespace Ladder
{
    internal static class Ladder
    {
        internal static string Build(uint input)
        {
            int n = (int)input;
            var answer = new StringBuilder ((1+n)*n/2 + n + 1 + (n+1)*(n/2) - (n+1)*(n+1)/8 + n/2+1);
            for (uint i = 1; i <= input; i++)
            {
                for (uint j = 0; j < i; j++)
                {
                    answer.Append('*'); // +(1+n)*n/2 symbols
                }
                answer.Append('\n'); // +n symbols
            }                                

            answer.Append('\n'); // +1 symbols
            if (input % 2 == 0) { input++; }

            for (uint i = 0; i<= input/2; i++)
            {
                for (uint j = 0; j < input/2-i; j++)
                {
                    answer.Append(' ');
                }
                for (uint j = 1; j <= i*2+1; j++)
                {
                    answer.Append('*');  //aproximately +(n/2+1)^2 -(n+1)*(n+1)/8  symbols
                }
                answer.Append('\n'); //+n/2+1 symbols
            }
            return answer.ToString();
        }
    }
}
