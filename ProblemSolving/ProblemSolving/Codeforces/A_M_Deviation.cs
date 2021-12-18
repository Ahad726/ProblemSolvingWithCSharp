using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class A_M_Deviation
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                var line = Console.ReadLine().Split(' ');
                int num1 = Convert.ToInt32(line[0]);
                int num2 = Convert.ToInt32(line[1]);
                int num3 = Convert.ToInt32(line[2]);

                var mean_deviation = num1 + num3 - (2 * num2);

                if (mean_deviation % 3 == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(1);
                }

            }
        }
    }
}
