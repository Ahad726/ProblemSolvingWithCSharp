using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class AquaMoon_and_Two_Arrays
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < n; x++)
            {
                var arrayLength = Convert.ToInt32(Console.ReadLine());
                var arrayA = Console.ReadLine().Split(' ').Take(arrayLength).Select(int.Parse).ToArray();
                var arrayB = Console.ReadLine().Split(' ').Take(arrayLength).Select(int.Parse).ToArray();

                var iList = new List<int>();
                var jList = new List<int>();
                var count = 0;
                var allSame = 0;

                var arrayASum = arrayA.Sum();
                var arrayBSum = arrayB.Sum();

                if (arrayASum != arrayBSum)
                {
                    Console.WriteLine("-1");
                    continue;
                }

                for (int i = 0; i < arrayLength;)
                {
                    if (arrayA[i] > arrayB[i])
                    {
                        // found i
                        iList.Add(i + 1);
                        arrayA[i] -= 1;

                        // search for j
                        for (int k = i + 1; k < arrayLength; k++)
                        {
                            if (arrayA[k] < arrayB[k])
                            {
                                //found j
                                jList.Add(k + 1);
                                arrayA[k] += 1;
                                break;
                            }
                        }
                        count++;
                    }
                    else if (arrayA[i] < arrayB[i])
                    {
                        // found j
                        jList.Add(i + 1);
                        arrayA[i] += 1;

                        // search for i
                        for (int k = i + 1; k < arrayLength; k++)
                        {
                            if (arrayA[k] > arrayB[k])
                            {
                                //found i
                                iList.Add(k + 1);
                                arrayA[k] -= 1;
                                break;
                            }
                        }
                        count++;
                    }
                    else
                    {
                        i++;
                        allSame++;
                        if (allSame == arrayLength)
                        {
                            break;
                        }

                    }
                }

                Console.WriteLine(count);

                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{iList[m]} {jList[m]}");
                }

            }
        }
    }
}
