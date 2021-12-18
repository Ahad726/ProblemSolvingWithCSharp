using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class WrongSubtraction
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            var n = Convert.ToInt64(line[0]);
            var k = Convert.ToInt32(line[1]);

            for (int i = 0; i < k; i++)
            {
                if (n % 10 == 0)
                {
                    n = n / 10;
                }
                else
                {
                    n -= 1;
                }
            }
            Console.WriteLine(n);
        }
    }
}
