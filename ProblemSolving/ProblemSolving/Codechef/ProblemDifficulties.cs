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
                var nmbrDict = new Dictionary<int,int>();

                foreach (var nmbr in nmbrArray)
                {
                    if (!nmbrDict.ContainsKey(nmbr))
                    {
                        nmbrDict.Add(nmbr, 0);
                    }
                    nmbrDict[nmbr] += 1;
                }

                var dictSize = nmbrDict.Count;

                if (dictSize == 3 || dictSize == 4)
                {
                    Console.WriteLine(2);
                }
                else if(dictSize == 2)
                {
                    if(nmbrDict.ElementAt(0).Value == 2)
                    {
                        Console.WriteLine(2);
                    }
                    else
                    {
                        Console.WriteLine(1);
                    }
                }
                else
                {
                    Console.WriteLine(0);
                }

            }
        }
    }
}
