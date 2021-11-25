using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Reverse_Sort
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                var str = Console.ReadLine();

                var numberOf0 = 0;
                for (int j = 0; j < length; j++)
                {
                    if (str[j] == '0')
                    {
                        numberOf0++;
                    }
                }



                var numberOf1 = length - numberOf0;

                var nmbrList = new List<int>();

                var misPositionCount = 0;

                for (int j = 0; j < numberOf0; j++)
                {
                    if (str[j] != '0')
                    {
                        nmbrList.Add(j);
                        misPositionCount++;
                    }
                }

                if (misPositionCount == 0)
                {
                    Console.WriteLine(0);
                    continue;
                }

                for (int j = numberOf0; j < length; j++)
                {
                    if (str[j] != '1')
                    {
                        nmbrList.Add(j);
                    }
                }

                Console.WriteLine(1);
                Console.Write(nmbrList.Count + " ");
                foreach (var item in nmbrList)
                {
                    Console.Write(item+1 + " ");
                }
            }
        }
    }
}
