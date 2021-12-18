using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class VanyaAndFence
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int frndsCount = Convert.ToInt32(line[0]);
            int fenchHeight = Convert.ToInt32(line[1]);

            var allFrndsHeight = Console.ReadLine().Split(' ').Take(frndsCount).Select(int.Parse);

            int heightCount = 0;

            foreach (var h in allFrndsHeight)
            {
                if (h > fenchHeight)
                {
                    heightCount += 2;
                }
                else
                {
                    heightCount++;
                }
            }

            Console.WriteLine(heightCount);
        }
    }
}
