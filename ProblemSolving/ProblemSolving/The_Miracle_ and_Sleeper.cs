using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class The_Miracle__and_Sleeper
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var line = Console.ReadLine().Split(' ');
                var l = Convert.ToInt32(line[0]);
                var r = Convert.ToInt32(line[1]);


                var halfOfR = r / 2;
                if (halfOfR >= l)
                {
                    var halfPlus1 = halfOfR + 1;
                    Console.WriteLine(r % halfPlus1);
                }
                else
                {
                    Console.WriteLine(r % l);
                }
            }
        }
    }
}
