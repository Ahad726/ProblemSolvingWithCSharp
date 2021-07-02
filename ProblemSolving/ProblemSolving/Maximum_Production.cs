using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class Maximum_Production
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var d = Convert.ToInt32(line[0]);
                var x = Convert.ToInt32(line[1]);
                var y = Convert.ToInt32(line[2]);
                var z = Convert.ToInt32(line[3]);

                var xUnitOfWork = 7 * x;

                var yUnitOfWork = d * y + (7 - d) * z;

                Console.WriteLine(Math.Max(xUnitOfWork,yUnitOfWork));
            }
        }
    }
}
