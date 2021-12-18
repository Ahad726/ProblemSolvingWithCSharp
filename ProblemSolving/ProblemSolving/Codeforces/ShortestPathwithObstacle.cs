using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class ShortestPathwithObstacle
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var emptyLine = Console.ReadLine();

                var aline = Console.ReadLine().Split(' ');
                var ax = Convert.ToInt32(aline[0]);
                var ay = Convert.ToInt32(aline[1]);

                var bline = Console.ReadLine().Split(' ');
                var bx = Convert.ToInt32(bline[0]);
                var by = Convert.ToInt32(bline[1]);

                var fline = Console.ReadLine().Split(' ');
                var fx = Convert.ToInt32(fline[0]);
                var fy = Convert.ToInt32(fline[1]);

                int minimumPathCount = 0;

                if (ax == bx && bx == fx)
                {
                    //a, b, f in same column

                    if ((ay < fy && fy < by) || (by < fy && fy < ay))
                    {
                        // f between a nd b
                        minimumPathCount = Math.Abs(ay - by) + 2;
                    }
                    else
                    {
                        minimumPathCount = Math.Abs(ay - by);
                    }
                }
                else if(ay == by && by == fy)
                {
                    // a , b, f in same row
                    if ((ax < fx && fx < bx) || (bx < fx && fx < ax))
                    {
                        minimumPathCount = Math.Abs(ax - bx) + 2;
                    }
                    else
                    {
                        // f is not between a and b
                        minimumPathCount = Math.Abs(ax - bx);
                    }
                }
                else
                {
                    minimumPathCount = Math.Abs(ay - by) + Math.Abs(ax - bx);
                }

                Console.WriteLine(minimumPathCount);
            }
        }
    }
}
