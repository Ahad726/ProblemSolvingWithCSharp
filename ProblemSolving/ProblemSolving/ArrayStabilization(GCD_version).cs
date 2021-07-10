using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProblemSolving
{
    class ArrayStabilization_GCD_version_
    {
        static void Main(string[] args)
        {

            var n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var arrayLength = Convert.ToInt32(Console.ReadLine());
                var nmbrArray = Console.ReadLine().Split(' ').Take(arrayLength).Select(int.Parse).ToArray();

                int count = 0;
                while (!IsAllEqual(nmbrArray))
                {
                    var firstElement = nmbrArray[0];
                    for (int j = 0; j < arrayLength-1; j++)
                    {
                        var gcd = GCD(nmbrArray[j], nmbrArray[j + 1]);
                        nmbrArray[j] = gcd;
                        if (j == arrayLength-2)
                        {
                            // j indicates the 2nd last. hence calculate the last and the first
                            nmbrArray[j + 1] = GCD(nmbrArray[j + 1], firstElement);
                        }
                    }
                    count++;
                }


                Console.WriteLine(count);
            }
        }

        static int GCD(int a, int b)
        {
            while (a > 0 && b > 0)
            {
                if (a >= b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return Math.Max(a, b);
        }

        static bool IsAllEqual(int[] nmbrArray)
        {
            var firstItem = nmbrArray[0];

            var result =  Array.TrueForAll(nmbrArray, c => c == firstItem);

            //bool result = true;

            //foreach (var nmbr in nmbrArray)
            //{
            //    if (nmbr != firstItem)
            //    {
            //        result = false;
            //    }
            //}

            return result;
        }
    }
}
