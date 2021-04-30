using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Elephant
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i = 5;
            while (n > 0)
            {
                if (n < 5)
                {
                    n = n - i;
                    i--;
                    count++;
                }
                else
                {
                    count += (n / 5); 
                    n = n % 5;
                }
                
            }

            Console.WriteLine(count);

        }
    }
}
