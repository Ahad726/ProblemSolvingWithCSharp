using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Domino_Disaster
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                int size = Convert.ToInt32(Console.ReadLine());
                var str = Console.ReadLine().ToCharArray();

                for (int i = 0; i < size; i++)
                {
                    if (str[i] == 'U')
                    {
                        str[i] = 'D';
                    }
                    else if(str[i] == 'D')
                    {
                        str[i] = 'U';
                    }
                }

                Console.WriteLine(new string(str));
            }
        }
    }
}
