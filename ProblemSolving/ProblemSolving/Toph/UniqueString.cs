using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Toph
{
    class UniqueString
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    count++;
                    
                }
            }

            if (count > 2)
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
