using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Relativity
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var g = Convert.ToInt32(line[0]);
                var c = Convert.ToInt32(line[1]);

                var result = (c / 2) * (c / g);

                Console.WriteLine(result);
            }
        }
    }
}
