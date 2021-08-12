using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codechef
{
    public class Chef_and_Bulb_Invention
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var line = Console.ReadLine().Split(' ');
                var n = Convert.ToInt32(line[0]);
                var p = Convert.ToInt32(line[1]);
                var k = Convert.ToInt32(line[2]);



                // number of same remainders 
                var remainderCount = (n / k);

                // value of remainder
                var remainder = (n % k); // 13 % 5 = 3

                var rem = (p % k); // 12 % 5 = 2

               

                var quotient = (p / k);




                long dayCount = rem * remainderCount;

                if (rem < remainder)
                {
                    dayCount += rem;
                }
                else
                {
                    dayCount += remainder;
                }

                dayCount += quotient + 1;

                Console.WriteLine(dayCount);
            }
        }
    }
}
