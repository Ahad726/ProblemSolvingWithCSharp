using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class BeautifulMatrix
    {
        static void Main(string[] args)
        {

            var matrix = new int[5,5];
            int row = 0;
            int col = 0;



            for (int i = 0; i <5; i++)
            {
                var arr = Console.ReadLine().Split(' ').Take(5).Select(int.Parse).ToArray();

                for (int j = 0; j < 5; j++)
                {
                    matrix[i,j] = arr[j];

                    if (matrix[i, j] == 1)
                    {
                        row = i;
                        col = j;
                    }

                }
            }


            int count = Math.Abs(2 - row) + Math.Abs(2 - col);
            Console.WriteLine(count);

        }
    }
}
