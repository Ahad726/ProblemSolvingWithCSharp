using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Bit
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input.Contains("++"))
                {
                    x++;
                }
                else if (input.Contains("--"))
                {
                    x--;
                }
            }

            Console.WriteLine(x);

        }
    }
}
