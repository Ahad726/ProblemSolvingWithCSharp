using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    public class Problem_A
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var size = Convert.ToInt32(Console.ReadLine());
                var nmbrArray = Console.ReadLine().Split(' ').Take(size).Select(double.Parse).ToArray();
                

                double maxSum = 0;

                Array.Sort(nmbrArray);

                var maxValue = nmbrArray[size - 1];

                nmbrArray[size - 1] = 0;

                var allSum = nmbrArray.Sum();

                double average = allSum / (size - 1);


                maxSum = Math.Round(maxValue + average,9);

                Console.WriteLine(maxSum);
            }
        }
    }
}
