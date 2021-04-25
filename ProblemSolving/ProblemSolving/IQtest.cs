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
            int index = 0;

            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    evenCOunt++;
                }
                else
                {
                    oddCount++;
                }
            }

            if (evenCOunt > oddCount)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        index = i;
                        break;
                    }
                }
            }

            else
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        index = i;
                        break;
                    }
                }
            }


            Console.WriteLine(index+1);
        }


    }
}
