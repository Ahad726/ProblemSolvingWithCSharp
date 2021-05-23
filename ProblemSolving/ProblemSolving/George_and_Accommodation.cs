using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class George_and_Accommodation
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                int peopleNmbr = Convert.ToInt32(line[0]);
                int capacity = Convert.ToInt32(line[1]);

                if (peopleNmbr <= capacity - 2)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
