using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class OptimalDenomination
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var totalEmp = Convert.ToInt32(Console.ReadLine());
                var salaryArray = Console.ReadLine().Split(' ').Take(totalEmp).Select(int.Parse).ToArray();
                var min = salaryArray.Min();
                var max = salaryArray.Max();

                bool havingOdd = false;

                foreach (var s in salaryArray)
                {
                    if (s % 2 != 0)
                    {
                        havingOdd = true;
                    }
                }
                Array.Sort(salaryArray);

                if (havingOdd)
                {
                    for (int j = salaryArray.Length - 1; j >= 0; j--)
                    {
                        if (salaryArray[j] == max)
                        {
                            salaryArray[j] = 1;
                        }
                        else
                        {
                            break;
                        }
                    }

                    int count = 0;
                    foreach (var s in salaryArray)
                    {
                        count += s / 1;
                    }

                    Console.WriteLine(count);
                }
                else
                {
                    for (int j = salaryArray.Length - 1; j >= 0; j--)
                    {
                        if (salaryArray[j] == max)
                        {
                            salaryArray[j] = min;
                        }
                        else
                        {
                            break;
                        }
                    }

                    int count = 0;
                    foreach (var s in salaryArray)
                    {
                        count += s / min;
                    }

                    Console.WriteLine(count);
                }

              
            }
        }
    }
}
