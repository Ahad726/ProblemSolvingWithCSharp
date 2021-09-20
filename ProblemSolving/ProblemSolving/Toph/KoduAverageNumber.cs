using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Toph
{
    class KoduAverageNumber
    {
        public static List<int> nmbrList = new List<int>();
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100000; i++)
            {
                int ithNumber = (i * (3 * i - 1)) / 2;
                nmbrList.Add(ithNumber);
            }

            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var n = Convert.ToInt32(Console.ReadLine());

                int sum = 0;

                for (int i = 0; i < n; i++)
                {
                    sum += nmbrList[i];
                }
               
                int average = sum / n;
                Console.WriteLine(average);
            }
        }
    }
}
