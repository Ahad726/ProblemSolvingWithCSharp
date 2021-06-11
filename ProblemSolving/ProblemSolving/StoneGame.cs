using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    public class StoneGame
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int k = 0; k < n; k++)
            {
                var arraySize = Convert.ToInt32(Console.ReadLine());
                var stonArray = Console.ReadLine().Split(' ').Take(arraySize).Select(int.Parse).ToArray();


                if (stonArray.Length == 2)
                {
                    Console.WriteLine(2);
                    continue;
                }

                int min = stonArray.Min();
                int max = stonArray.Max();


                //  left and right
                int leftMatch = 0;
                for (int a = 0; a < stonArray.Length; a++)
                {
                    leftMatch++;
                    if (stonArray[a] == max || stonArray[a] == min)
                    {
                        break;
                    }
                }

                int rightmatch = 0;
                for (int b = stonArray.Length - 1; b > 0; b--)
                {
                    rightmatch++;
                    if (stonArray[b] == max || stonArray[b] == min)
                    {
                        break;
                    }
                }

                int leftRightMatch = leftMatch + rightmatch;


                // from left side
                int fromLeftMatch = 0;
                int i = 0;
                for (; i < stonArray.Length; i++)
                {
                    if (stonArray[i] == max || stonArray[i] == min)
                    {
                        fromLeftMatch++;
                        if (fromLeftMatch == 2)
                        {
                            break;
                        }
                    }
                }

                int leftCount = i + 1;


                // from right side
                int fromRightMatch = 0;
                int rightCount = 0;
                int j = stonArray.Length - 1;
                for (; j > 0; j--)
                {
                    rightCount++;
                    if (stonArray[j] == max || stonArray[j] == min)
                    {
                        fromRightMatch++;
                        if (fromRightMatch == 2)
                        {
                            break;
                        }
                    }
                }

                int result = Math.Min(Math.Min(leftCount, rightCount), leftRightMatch);
                Console.WriteLine(result);




            }
        }

    }
}
