using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class DislikeThrees
    {
        static void Main(string[] args)
        {
            var nmbrList = new List<int>();

            for (int i = 1; i < 1700; i++)
            {
                var nmbrStr = i.ToString();

                if (i % 3 != 0)
                {
                    if (!nmbrStr.EndsWith("3"))
                    {
                        nmbrList.Add(i);
                    }
                }
            }

            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {

                var n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(nmbrList[n - 1]);
            }
        }
    }
}
