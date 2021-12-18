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
                var n = Convert.ToInt64(Console.ReadLine());

                var enemyPawns = Console.ReadLine().ToCharArray();

                var Gregorpawns = Console.ReadLine().ToCharArray();

                long count = 0;      

                for (int i = 0; i < n; i++)
                {

                    var grgPaw = Gregorpawns[i];

                    if (grgPaw == '1')
                    {
                        // check if enemy cell is empty than increase count
                        if (enemyPawns[i] == '0')
                        {
                            enemyPawns[i] = '2';
                            count++;
                        }
                        else
                        {
                            // enemy cell is not empty. Check adjacent cells of this enemy cell

                            var j = i - 1;  //  left cell

                            var k = i + 1; // right cell

                            if (j > -1)
                            {
                                if (enemyPawns[j] == '1')
                                {
                                    enemyPawns[j] = '2';
                                    count++;
                                    continue;
                                }
                            }
                            if( k < n)
                            {
                                if (enemyPawns[k] == '1')
                                {
                                    enemyPawns[k] = '2';
                                    count++;
                                }
                            }

                        }


                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
