using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Update_Files
    {
        static void Main(string[] args)
        {
            var tstCase = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < tstCase; t++)
            {
                var line = Console.ReadLine().Split(' ');
                var n = Convert.ToInt64(line[0]);
                var k = Convert.ToInt64(line[1]);


                if (n == 1)
                {
                    Console.WriteLine(0);
                    continue;
                }
                int hourCount = 0;
                long updatedComp = 1;

               

                for (int j = 1; n > updatedComp; j++)
                {
                    hourCount++;
                    updatedComp = updatedComp * 2;

                    var patchCable = updatedComp / 2;


                    if (patchCable <= k)
                    {
                        n -= updatedComp;
                    }
                    else
                    {
                        updatedComp = k * 2;

                        if (n - updatedComp <= k)
                        {
                            hourCount++;
                            break;
                        }
                    }


                }

                Console.WriteLine(hourCount);

            }
        }
    }
}
