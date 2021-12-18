using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Slay_the_Dragon
    {
        static void Main(string[] args)
        {
            var heroCount = Convert.ToInt32(Console.ReadLine());

           var herosStrength = Console.ReadLine().Split(' ').Take(heroCount).Select(long.Parse).ToArray();

            var heroMaxStrgth = herosStrength.Max();

            var herosStrngthSum = herosStrength.Sum();
            var max = herosStrngthSum;

            var dragonCount = Convert.ToInt64(Console.ReadLine());

            for (int i = 0; i < dragonCount; i++)
            {
                herosStrngthSum = max;

                var line = Console.ReadLine().Split(" ");

                var dragonDef = Convert.ToInt64(line[0]);
                var dragonAttck = Convert.ToInt64(line[1]);

                var dragonPower = dragonAttck + dragonDef;

                var coinNeedCount = 0L;


                if (dragonDef > heroMaxStrgth)
                {
                    coinNeedCount = dragonDef - heroMaxStrgth;
                    herosStrngthSum -= heroMaxStrgth;
                }
                else
                {
                    herosStrngthSum -= dragonDef;
                }

                if (herosStrngthSum < dragonAttck)
                {
                    coinNeedCount += dragonAttck - herosStrngthSum;
                }

                // previous
                //if (dragonPower > herosStrngthSum)
                //{
                //    coinNeedCount = dragonPower - herosStrngthSum;
                //}

                //if (dragonDef > heroMaxStrgth)
                //{
                //    var herosPowerInc = dragonDef - heroMaxStrgth;
                //    if (coinNeedCount < herosPowerInc)
                //    {
                //        coinNeedCount = herosPowerInc;
                //    }
                //}

                Console.WriteLine(coinNeedCount);

            }
        }
    }
}
