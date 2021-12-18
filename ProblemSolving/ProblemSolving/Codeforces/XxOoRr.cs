using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    public class XxOoRr
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var arrayLength = Convert.ToInt32(line[0]);
                var k = Convert.ToInt32(line[1]);
                var nmbrArray = Console.ReadLine().Split(' ').Take(arrayLength).Select(int.Parse).ToArray();

                var countArray = new int[32];

                for (int j = 0; j < arrayLength; j++)
                {
                    var l = 0;
                    while (nmbrArray[j] != 0)
                    {
                        countArray[l] += nmbrArray[j] % 2;
                        l++;
                        nmbrArray[j] /= 2;
                    }
                }

                int count = 0;
                foreach (int nmbr in countArray)
                {
                    if (nmbr % k == 0)
                    {
                        count += nmbr / k;
                    }
                    else
                    {
                        count += nmbr / k + 1;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
