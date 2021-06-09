using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class OmkarAndBadStory
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int k = 0; k < n; k++)
            {
                var arraySize = Convert.ToInt32(Console.ReadLine());
                var arrayA = Console.ReadLine().Split(' ').Take(arraySize).Select(int.Parse).ToList();
                int addCount = 0;
                bool isNice = false;

                for (int i = 0; i < arrayA.Count - 1; i++)
                {
                    for (int j = i+1; j < arrayA.Count; j++)
                    {
                        int result;
                        if (arrayA[i] > arrayA[j])
                        {
                            result = arrayA[i] - arrayA[j];
                        }
                        else
                        {
                            result = arrayA[j] - arrayA[i];
                        }

                        if (!arrayA.Contains(result))
                        {
                            i = 0;
                            j = i;
                            arrayA.Add(result);
                            isNice = true;
                            addCount++;
                        }
                    }

                    if (i == arrayA.Count -1)
                    {
                        break;
                    }

                    if (addCount == 300)
                    {
                        break;
                    }
                }

                if (isNice)
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(arrayA.Count);
                    for (int m = 0; m < arrayA.Count; m++)
                    {
                        Console.Write($"{arrayA[m]} ");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
                Console.WriteLine();
            }

        }
    }
}
