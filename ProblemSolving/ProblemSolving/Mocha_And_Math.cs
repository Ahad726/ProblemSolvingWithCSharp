using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class Mocha_And_Math
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var size = Convert.ToInt32(Console.ReadLine());

                var nmbrArray = Console.ReadLine().Split(' ').Take(size).Select(int.Parse).ToArray();

                var minVal = nmbrArray[0];
                for (int i = 0; i < size; i++)
                {
                    minVal = nmbrArray[i] & minVal;
                }

                Console.WriteLine(minVal);



            }
        }
    }
}
