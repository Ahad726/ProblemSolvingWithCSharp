using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Potion_making
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int essence = Convert.ToInt32(Console.ReadLine());

                if (100 % essence == 0)
                {
                    Console.WriteLine(100/essence);
                }
                else
                {
                    Console.WriteLine(100);
                }
            }
        }
    }
}
