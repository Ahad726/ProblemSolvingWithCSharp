using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class OddSet
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var totalnmbr = Convert.ToInt32(Console.ReadLine());
                var nmbrArray = Console.ReadLine().Split(' ').Take(totalnmbr * 2).Select(int.Parse).ToArray();

                int evencount = 0;
                int oddcount = 0;

                foreach (var nmbr in nmbrArray)
                {
                    if (nmbr % 2 == 0)
                    {
                        evencount++;
                    }
                    else
                    {
                        oddcount++;
                    }
                }

                var result = evencount == oddcount ? "Yes" : "No";
                Console.WriteLine(result);
            }

        }
    }
}
