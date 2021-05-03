using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class NearlyLuckyNumber
    {
        static void Main(string[] args)
        {

           var nmbr =Console.ReadLine();
            int count = 0;
            foreach (var item in nmbr)
            {
                
                if (item == '4' || item == '7')
                {
                    count++;
                }
            }

            if (count == 4 || count == 7)
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
