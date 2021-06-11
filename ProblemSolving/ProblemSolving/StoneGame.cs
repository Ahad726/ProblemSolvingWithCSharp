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

                int min = stonArray.Min();
                int max = stonArray.Max();

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
                for (int b = stonArray.Length-1; b > 0; b--)
                {
                    rightmatch++;
                    if (stonArray[b] == max || stonArray[b] == min)
                    {
                        break;
                    }
                }

                if (leftMatch <= rightmatch)
                {
                    int i = 0;

                    for (; i < stonArray.Length; i++)
                    {
                        if (stonArray[i] == max || stonArray[i] == min)
                        {
                            break;
                        }
                    }

                    int j = i + 1;
                    int stepCountAfterLeftMatch = 0;
                    for (; j < stonArray.Length; j++)
                    {
                        stepCountAfterLeftMatch++;
                        if (stonArray[j] == max || stonArray[j] == min)
                        {
                            break;
                        }
                    }

                    int rightCount = 0;
                    for (int m = stonArray.Length - 1; m > i; m--)
                    {
                        rightCount++;
                        if (stonArray[m] == max || stonArray[m] == min)
                        {
                            break;
                        }
                    }



                    int seconMatch = Math.Min(stepCountAfterLeftMatch, rightCount);

                    int result = i + 1 + seconMatch;

                    Console.WriteLine(result);
                }

                else
                {

                    int i = stonArray.Length - 1;
                    int rightCount = 0;

                    for (; i >= 0; i--)
                    {
                        rightCount++;
                        if (stonArray[i] == max || stonArray[i] == min)
                        {
                            break;
                        }
                    }

                    int j = i -1 ;
                    int stepCountrightMatchToLeft = 0;
                    for (; j >= 0; j--)
                    {
                        stepCountrightMatchToLeft++;
                        if (stonArray[j] == max || stonArray[j] == min)
                        {
                            break;
                        }
                    }

                    int leftmatch = 0;

                    for (int m = 0; m < i; m++)
                    {
                        leftmatch++;
                        if (stonArray[m] == max || stonArray[m] == min)
                        {
                            break;
                        }
                    }

                    int seconMatch = Math.Min(stepCountrightMatchToLeft, leftmatch);

                    int result = rightCount + seconMatch;

                    Console.WriteLine(result);

                }

            }
        }

    }
}
