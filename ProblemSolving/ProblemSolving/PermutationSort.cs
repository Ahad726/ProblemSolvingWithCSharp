using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class PermutationSort
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                int d = Convert.ToInt32(Console.ReadLine());

                var arr = Console.ReadLine().Split(' ').Take(d).Select(int.Parse).ToArray();

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        count++;
                    }
                }

                Console.Write(count);
                Console.WriteLine();
            }

        }
    }
}
