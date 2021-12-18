using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Odd_Grasshopper
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var initCoordinate = Convert.ToInt64(line[0]);
                var numberOfJumps = Convert.ToInt64(line[1]);

                var numberOfJumpsMod4 = numberOfJumps % 4;

                if (numberOfJumpsMod4 == 1)
                {
                    if (numberOfJumps < 4)
                    {
                        Console.WriteLine(initCoordinate - 1);
                    }
                    else
                    {
                        if (initCoordinate % 2 == 0)
                        {
                            Console.WriteLine(initCoordinate - numberOfJumps);

                        }
                        else
                        {

                            Console.WriteLine(initCoordinate + numberOfJumps);
                        }

                    }
                }

                else if (numberOfJumpsMod4 == 2)
                {
                    Console.WriteLine(initCoordinate + 1);
                }
                else if (numberOfJumpsMod4 == 3)
                {
                    if (numberOfJumps < 4)
                    {
                        Console.WriteLine(initCoordinate + 4);
                    }
                    else
                    {
                        Console.WriteLine(initCoordinate + 1 + numberOfJumps);
                    }
                }
                else
                {
                    Console.WriteLine(initCoordinate);
                }
            }
        }


    }
}
