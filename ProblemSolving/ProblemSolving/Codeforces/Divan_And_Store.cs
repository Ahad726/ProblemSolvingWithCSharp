using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving.Codeforces
{
    class Divan_And_Store
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var ChocolateCount = Convert.ToInt32(line[0]);
                var lowestPrice = Convert.ToInt32(line[1]);
                var highestPrice = Convert.ToInt32(line[2]);
                var budget = Convert.ToInt32(line[3]);

                var priceArray = Console.ReadLine().Split(' ').Take(ChocolateCount).Select(int.Parse).ToArray();

                Array.Sort(priceArray);
                var buyCount = 0;
                foreach (var price in priceArray)
                {
                    if (price >= lowestPrice && price <= highestPrice)
                    {
                       
                        if (budget >= price)
                        {
                            buyCount++;
                            budget -= price;
                        }
                    }
                }
                Console.WriteLine(buyCount);
            }

        }
    }
}
