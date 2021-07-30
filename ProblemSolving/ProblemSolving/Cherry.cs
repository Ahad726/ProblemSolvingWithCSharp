using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProblemSolving
{
    public class Cherry
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int p = 0; p < t; p++)
            {
                var arrayLength = Convert.ToInt32(Console.ReadLine());
                var nmbrArray = Console.ReadLine().Split(' ').Take(arrayLength).Select(long.Parse).ToArray();


                long result = 0;

                for (int i = 0; i < nmbrArray.Length-1; i++)
                {
                    result = Math.Max(result , nmbrArray[i]*nmbrArray[i+1]);
                }

                Console.WriteLine(result);

            }
        }

    }
}
