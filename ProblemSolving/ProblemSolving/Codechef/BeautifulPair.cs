using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ProblemSolving.Codechef
{
    public class BeautifulPair
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var arraySize = Convert.ToInt32(Console.ReadLine());

                var nmbrArray = Console.ReadLine().Split(' ').Take(arraySize).Select(int.Parse);

                var nmbrDic = new Dictionary<int, int>();

                foreach (var nmbr in nmbrArray)
                {
                    
                    if (!nmbrDic.ContainsKey(nmbr))
                    {
                        nmbrDic[nmbr] = 0;
                    }
                    nmbrDic[nmbr] += 1;
                }

                var pairCount = 0;

                foreach (var dic in nmbrDic)
                {
                    pairCount += (arraySize - dic.Value) * dic.Value;
                }

                Console.WriteLine(pairCount);
            }
        }
    }
}
