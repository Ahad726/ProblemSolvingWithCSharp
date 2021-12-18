using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Tram
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] inArray = new int[n];
            int[] outArray = new int[n];

            int maxPassenger = 0;
            int tempPassenger = 0;

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                outArray[i] = Convert.ToInt32(line[0]);
                inArray[i] = Convert.ToInt32(line[1]);
            }


            for (int i = 0; i < n; i++)
            {
                tempPassenger = (tempPassenger - outArray[i]) + inArray[i];

                if (tempPassenger > maxPassenger)
                {
                    maxPassenger = tempPassenger;
                }
            }

            Console.WriteLine(maxPassenger);
        }
    }
}
