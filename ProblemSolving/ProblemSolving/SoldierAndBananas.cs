using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class SoldierAndBananas
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            int costOfBanana = Convert.ToInt32(line[0]);
            int totalDollar = Convert.ToInt32(line[1]);
            int totalBanana = Convert.ToInt32(line[2]);

            int totalCost = 0;

            for (int i = 1; i <= totalBanana; i++)
            {
                totalCost += i * costOfBanana;
            }


            int borrow = totalCost > totalDollar ? (totalCost - totalDollar) : 0;

            Console.WriteLine(borrow);

        }
    }
}
