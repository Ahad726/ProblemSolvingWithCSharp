using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class DominoPiling
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(line[0]);
            int n = Convert.ToInt32(line[1]);

            var result = Math.Floor( (m *n) / 2.0);

            Console.WriteLine(result);
        }
    }
}
