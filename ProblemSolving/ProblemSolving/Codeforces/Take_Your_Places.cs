using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Take_Your_Places
    {
        public static int stepCount = 0;
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                int size = Convert.ToInt32(Console.ReadLine());
                var nmbrArray = Console.ReadLine().Split(' ').Take(size).Select(int.Parse).ToArray();
                stepCount = 0;

                if (size == 1)
                {
                    Console.WriteLine(0);
                    continue;
                }

                var binaryArray = new int[size];

                int oddCount = 0;

                for (int i = 0; i < size; i++)
                {
                    if (nmbrArray[i] % 2 != 0)
                    {
                        oddCount++;
                       // binaryArray[i] = 1;
                    }
                }

                if (size/2 != oddCount)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                while (IsSwapable(nmbrArray))
                {
                    Swap(nmbrArray);
                }

                Console.WriteLine(stepCount);

            }
        }

        static void Swap(int[] nmArray)
        {
            for (int i = 0; i < nmArray.Length-1; i++)
            {
                if (nmArray[i]%2 == nmArray[i+1]%2)
                {
                    if (i+2 < nmArray.Length && nmArray[i+1]%2 != nmArray[i + 2]%2)
                    {
                        var temp = nmArray[i+1];
                        nmArray[i+1] = nmArray[i + 2];
                        nmArray[i + 2] = temp;
                        stepCount++;
                        break;
                    }
                    
                }
            }
        }

        static bool IsSwapable(int[] nmArray)
        {
            for (int i = 0; i < nmArray.Length-1; i++)
            {
                if (nmArray[i]%2 == nmArray[i+1]%2)
                {
                    return true;
                    
                }
            }
            return false;
        }
    }
}
