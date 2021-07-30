using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProblemSolving
{
    public class PizzaForces
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int p = 0; p < t; p++)
            {
                var n = Convert.ToInt64(Console.ReadLine());

                if (n <= 6)
                {
                    Console.WriteLine(15);
                }
                else
                {
                    long divResult =(long)Math.Ceiling((decimal)n / 2);
                    Console.WriteLine(divResult*5);
                }
            }
        }

      
    }
}
