using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codechef
{
    public class FriendGroupsLine
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var line = Console.ReadLine().Split(' ');
                var n = Convert.ToInt64(line[0]);
                var k = Convert.ToInt64(line[1]);

                var frndsLine = Console.ReadLine();

                var lastPosition = frndsLine.IndexOf('1');
                var newPosition = 0;



                for (int i = lastPosition + 1; i < n; i++)
                {
                    if (frndsLine[i] == '1')
                    {
                        newPosition = i;
                    }

                    if (newPosition - lastPosition > k)
                    {

                    }
                }


            }
        }
    }
}
