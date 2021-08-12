using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codechef
{
    public class ProblemDifficulties
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var nmbrArray = Console.ReadLine().Split(' ').Take(4).Select(int.Parse).ToArray();
                var distnctList = new List<int>();

                foreach (var nmbr in nmbrArray)
                {
                    if (!distnctList.Contains(nmbr))
                    {
                        distnctList.Add(nmbr);
                    }
                }

                var l = distnctList.Count;
                
                if(l == 2)
                {
                    Console.WriteLine(1);
                }
                else if( l > 2)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(0);
                }
                
                
            }
        }
    }
}
