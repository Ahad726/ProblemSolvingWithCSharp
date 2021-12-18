using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class IQtest
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var arr = Console.ReadLine().Split(' ').Take(n).Select(int.Parse).ToArray();

            int evenCOunt = 0;
            int oddCount = 0;
            int evenIndex = 0;
            int oddIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    evenIndex = i;
                    evenCOunt++;
                }
                else
                {
                    oddIndex = i;
                    oddCount++;
                }
            }
 

            if (evenCOunt > oddCount)
            {
                Console.WriteLine(oddIndex+1);
            }

            else
            {
                Console.WriteLine(evenIndex + 1);
               
            }
        }


    }
}
