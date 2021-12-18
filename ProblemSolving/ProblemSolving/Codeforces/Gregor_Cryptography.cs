using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class Gregor_Cryptography
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int p = 0; p < t; p++)
            {
                var P = Convert.ToInt64(Console.ReadLine());

                var b = P - 1;

                var a = b/2;

                Console.WriteLine($"{a} {b}");
            }
        }
    }
}
