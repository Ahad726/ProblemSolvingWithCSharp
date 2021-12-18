using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProblemSolving.Codeforces
{
    class Life_of_Flower
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                int days = Convert.ToInt32(Console.ReadLine());
                var daysArray = Console.ReadLine().Split(' ').Take(days).Select(int.Parse).ToArray();

                var finalHeight = 1;
                var isDie = false;


                if (daysArray[0] == 1)
                {
                    finalHeight++;
                }


                for (int j = 1; j < days; j++)
                {
                    var daysWater = daysArray[j];

                    if (daysWater == 1)
                    {
                        if (daysArray[j - 1] == 1)
                        {
                            finalHeight += 5;
                        }
                        else
                        {
                            finalHeight++;

                        }
                    }
                    else
                    {
                        if (daysArray[j - 1] == 0)
                        {
                            isDie = true;
                            break;
                        }
                    }
                }
                if (isDie)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(finalHeight);
                }

            }
        }
    }
}
