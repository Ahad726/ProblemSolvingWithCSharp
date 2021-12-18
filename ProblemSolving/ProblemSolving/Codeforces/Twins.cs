using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class Twins
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var coins = Console.ReadLine().Split(' ').Take(n).Select(int.Parse).ToArray();

            Array.Sort(coins);

            int totalCoins = coins.Sum();
            int count = 0;
            int myPart = 0;
            int myTwinsPart = 0;

            for (int i = coins.Length -1; i >= 0 ; i--)
            {
                myPart += coins[i];
                myTwinsPart = totalCoins - myPart;
                count++;
                if (myPart > myTwinsPart)
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }

    }
}
