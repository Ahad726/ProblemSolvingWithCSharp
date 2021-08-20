using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class Who_Opposite
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var line = Console.ReadLine().Split(' ');
                var a = Convert.ToInt32(line[0]);
                var b = Convert.ToInt32(line[1]);
                var c = Convert.ToInt32(line[2]);

                var diff = Math.Abs(a - b);

                var max =  2 * diff;

                if (a > max || b > max)
                {
                    Console.WriteLine(-1);
                    continue;
                }
                

                if (c <= max && max > 2)
                {
                    if (c > diff)
                    {
                        Console.WriteLine(c - diff);
                    }
                    else
                    {
                        Console.WriteLine(c + diff);
                    }

                }
                else
                {
                    Console.WriteLine(-1);
                }

            }
        }
    }
}
