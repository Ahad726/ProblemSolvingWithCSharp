using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Searching
{
    // row wise, column wise sorted
    internal class SearchIn2DArray
    {
        static void Main(string[] args)
        {
            int[,] arr =
            {
                {10,20,30},
                {15,25,35},
                {28,29,37},
                {33,34,38}
            };

            var result = Search(arr, 33);

            Console.WriteLine(String.Join(',',result));
        }

        static int[] Search(int[,] matrix, int target)
        {
            int matrixRow = matrix.GetLength(0);
            int matrixCol = matrix.GetLength(1);

            int r = 0;
            int c = matrixCol - 1;

            while (r < matrixRow && c >= 0)
            {
                if (matrix[r,c] == target)
                {
                    return new int[] { r, c }; 
                }
                else if (matrix[r,c] < target)
                {
                    r++;
                }
                else
                {
                    c--;
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
