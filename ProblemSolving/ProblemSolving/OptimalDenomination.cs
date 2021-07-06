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

                int gcdValue = 0;

                for (int j = 0; j < salaryArray.Length; j++)
                {
                    gcdValue = GCD(gcdValue, salaryArray[j]);
                }

                var arraymax = salaryArray.Max();

                for (int k = 0; k < salaryArray.Length; k++)
                {
                    if (salaryArray[k] == arraymax)
                    {
                        salaryArray[k] = gcdValue;
                    }
                }

                int noteCount = 0;
                foreach (var item in salaryArray)
                {
                    noteCount += item / gcdValue;
                }

                Console.WriteLine(noteCount);
            }
        }

        static int GCD(int nmbr1, int nmbr2)
        {
            while (nmbr1 > 0 && nmbr2 > 0)
            {
                if (nmbr1 >= nmbr2 )
                {
                    nmbr1 %= nmbr2;
                }
                else
                {
                    nmbr2 %= nmbr1;
                }
            }
            return Math.Max(nmbr1, nmbr2);
        }
    }
}
