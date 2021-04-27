using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class StonesOnTheTable
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var stones = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < stones.Length-1; i++)
            {
                if (stones[i] == stones[i+1])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
