using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class A_Variety_Operations
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var line = Console.ReadLine().Split(' ');
                var a = Convert.ToInt32(line[0]);
                var b = Convert.ToInt32(line[1]);

                var sum = a + b;

                if (a == 0 && b == 0)
                {
                    Console.WriteLine(0);
                }
                else if(a == b)
                {
                    Console.WriteLine(1);
                }
                else if (sum %  2 == 0)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
            
        }
    }
}
