using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Recursion
{
    internal class MazeProblem
    {
        static void Main(string[] args)
        {
            //var pathCount = Count(3, 3);
            //Console.WriteLine(pathCount);

            //Path("", 3, 3);

            //var allPath = PathReturn("", 3, 3);
            //foreach (var path in allPath)
            //{
            //    Console.WriteLine(path);
            //}

            var maze = new bool[,]
            {
                {true,true,true},
                {true,true,true},
                {true,true,true}

            };

            var path = new int[,]
            {
                {0,0,0 },
                {0,0,0 },
                {0,0,0 }
            };

            AllDirection("", 0, 0, maze, path , 1);
            //Print2DArray<bool>(maze);
        }


        // backtracking

        /// <summary>
        /// maze in all 4 direction
        /// </summary>
        /// <param name="p">Track the step Right or Left or Down or Up</param>
        /// <param name="r">row</param>
        /// <param name="c">column</param>
        /// <param name="maze"></param>
        /// <param name="path">Numeric path in Integer</param>
        /// <param name="Step">path number</param>
        static void AllDirection(string p, int r, int c, bool[,] maze, int[,] path, int Step)
        {
            if (!maze[r, c])
            {
                return;
            }

            if (r == maze.GetLength(0) - 1 && c == maze.GetLength(1) - 1)
            {
                path[r, c] = Step;
                Console.WriteLine(p);
                Print2DArray<int>(path);
                Console.WriteLine();
                return;
            }

            maze[r, c] = false;
            path[r, c] = Step;



            if (r > 0)
            {
                AllDirection(p + 'U', r - 1, c, maze, path, Step+1);
            }
            if (c > 0)
            {
                AllDirection(p + 'L', r, c - 1, maze, path, Step + 1);
            }

            if (c < maze.GetLength(1) - 1) // go right whenif column less than upper bound
            {
                AllDirection(p + 'R', r, c + 1, maze, path, Step + 1);
            }
            if (r < maze.GetLength(0) - 1)
            {
                AllDirection(p + 'D', r + 1, c, maze, path, Step + 1);
            }

            maze[r, c] = true;
            path[r, c] = 0;

        }


        /// <summary>
        /// Return all path as a list
        /// </summary>
        /// <param name="p"></param>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static IList<string> PathReturn(string p, int r, int c)
        {
            if (r == 1 && c == 1)
            {
                var eachList = new List<string>();
                eachList.Add(p);
                return eachList;
            }

            var list = new List<string>();

            if (r > 1)
            {
                list.AddRange(PathReturn(p + 'D', r - 1, c));
            }
            if (c > 1)
            {
                list.AddRange(PathReturn(p + 'R', r, c - 1));
            }
            return list;
        }


        static void Path(string p, int r, int c)
        {
            if (r == 1 && c == 1)
            {
                Console.WriteLine(p);
                return;
            }
            if (r > 1)
            {
                Path(p + 'D', r - 1, c);
            }
            if (c > 1)
            {
                Path(p + 'R', r, c - 1);
            }
        }



        /// <summary>
        /// In this Maze count program , we can go only down or right.
        /// </summary>
        /// <param name="r">row</param>
        /// <param name="c">Column</param>
        /// <returns>Number of path</returns>
        static int Count(int r, int c)
        {
            if (r == 1 || c == 1)
            {
                return 1;
            }
            int left = Count(r - 1, c);
            int right = Count(r, c - 1);

            return left + right;
        }


        static void Print2DArray<T>(T[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
