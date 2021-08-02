using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ProblemSolving.Codechef
{
    public class RedAlert
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int p = 0; p < t; p++)
            {

                var line = Console.ReadLine().Split(' ');
                var N = Convert.ToInt32(line[0]);
                var D = Convert.ToInt32(line[1]);
                var H = Convert.ToInt32(line[2]);

                var nmbrArray = Console.ReadLine().Split(' ').Take(N).Select(int.Parse).ToArray();

                var totalsum = 0;

                for (int i = 0; i < N; i++)
                {

                   
                    if (nmbrArray[i] != 0)
                    {
                        totalsum += nmbrArray[i];
                        if (totalsum > H)
                        {
                            break;
                        }
                    }
                    else
                    {
                        totalsum -= D;
                        if (totalsum < 0)
                        {
                            totalsum = 0;
                        }
                    }
                }
                if (totalsum > H)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
