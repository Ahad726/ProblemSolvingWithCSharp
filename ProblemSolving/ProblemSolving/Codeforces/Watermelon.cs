using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Watermelon
    {
        static void Main(string[] args)
        {
            int watermelonWeight = Convert.ToInt32(Console.ReadLine());

            if (watermelonWeight % 2 == 0 && watermelonWeight > 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
