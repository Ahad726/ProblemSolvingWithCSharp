using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(line[0]);
                int b = Convert.ToInt32(line[1]);

                Console.WriteLine(a+b);
            }
        }
    }
}
