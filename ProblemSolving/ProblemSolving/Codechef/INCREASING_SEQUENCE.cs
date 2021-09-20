using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving.Codechef
{
    class INCREASING_SEQUENCE
    {
        static void Main(string[] args)
        {
            var size = Convert.ToInt32(Console.ReadLine());
            var nmbrArray = Console.ReadLine().Split(' ').Take(size).Select(long.Parse).ToArray();

            int count = 1;

            for (int i = 0; i < size-1; i++)
            {
                if (nmbrArray[i] < nmbrArray[i+1])
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
