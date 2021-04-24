using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class NextRound
    {
        static void Main(string[] args)
        {


            var line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int kthPlace = Convert.ToInt32(line[1]);

            var arr = Console.ReadLine().Split(' ').Take(n).Select(int.Parse).ToArray();

            int value = arr[kthPlace-1];
            int count = 0;
            foreach (var item in arr)
            {
                if (item >= value && item != 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
