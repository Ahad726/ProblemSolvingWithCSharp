using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class FriendsAndCandies
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var size = Convert.ToInt32(Console.ReadLine());
                var candiesArray = Console.ReadLine().Split(' ').Take(size).Select(Int64.Parse).ToArray();

                var sum = candiesArray.Sum();

                var average = sum / size;

                if (sum % size != 0)
                {
                    Console.WriteLine("-1");
                    continue;
                }

                int count = 0;

                foreach (var frndsCandy in candiesArray)
                {
                    if (frndsCandy > average)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
