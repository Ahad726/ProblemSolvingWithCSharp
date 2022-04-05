using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    internal class NumOfStep
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfSteps(14));
        }

        public static int NumberOfSteps(int num)
        {
            return Helper(num, 0);
        }

        private static int Helper(int num, int count)
        {
            if (num == 0)
            {
                return count ;
            }

            if (num % 2 == 0)
            {
                return Helper(num / 2, count + 1);
            }
            else
            {
                return Helper(num -1,count + 1);
            }
        }
    }
}
