using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProblemSolving
{
    public class TwoTables
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int p = 0; p < t; p++)
            {
                var line = Console.ReadLine().Split(' ');
                var roomWidth = Convert.ToInt64(line[0]);
                var roomHeight = Convert.ToInt64(line[1]);

                line = Console.ReadLine().Split(' ');
                var x1 = Convert.ToInt64(line[0]);
                var y1 = Convert.ToInt64(line[1]);
                var x2 = Convert.ToInt64(line[2]);
                var y2 = Convert.ToInt64(line[3]);

                line = Console.ReadLine().Split(' ');
                var newTblWidth = Convert.ToInt64(line[0]);
                var newTblHeight = Convert.ToInt64(line[1]);


                var existingTbleWidth = x2 - x1;
                var existingTbleHeight = y2 - y1;

                var remainingWidth = roomWidth - existingTbleWidth;
                var remainingHeight = roomHeight - existingTbleHeight;

                var exTblWidthLeft = x1;
                var exTbleWidthRight = roomWidth - x2;

                var exTblHeightUp = roomHeight - y2;
                var exTblHeightDown = y1;

                long step = 0;

                if ((newTblWidth <= exTbleWidthRight || newTblWidth <= exTblWidthLeft) ||
                    (newTblHeight <= exTblHeightUp || newTblHeight <= exTblHeightDown))
                {
                    // new Table fit either ex table up -down or left-right. no need to moov
                    Console.WriteLine(step);
                    continue;
                }

                if (newTblWidth <= remainingWidth )
                {

                    // find the maximum space left
                    var maxSpace = Math.Max(exTbleWidthRight, exTblWidthLeft);

                    // minimum space need to moov
                    step = newTblWidth - maxSpace;


                    //if (newTblHeight > exTblHeightUp || newTblHeight > exTblHeightDown)
                    //{
                    //    // after fitting width , also need to fit height
                       
                    //    var maxHeightSpace = Math.Max(exTblHeightUp, exTblHeightDown);

                    //    // minimum space need to moov
                    //    step += newTblHeight - maxHeightSpace;
                    //}

                    Console.WriteLine(step);

                }
                else if (newTblHeight <= remainingHeight)
                {
                    // find the maximum space left
                    var maxSpace = Math.Max(exTblHeightUp, exTblHeightDown);

                    // minimum space need to moov
                    step = newTblHeight - maxSpace;

                    //if (newTblWidth > exTbleWidthRight || newTblWidth > exTblWidthLeft)
                    //{
                    //    // after fitting width , also need to fit height

                    //    var maxWidthSpace = Math.Max(exTbleWidthRight, exTblWidthLeft);

                    //    // minimum space need to moov
                    //    step += newTblHeight - maxWidthSpace;
                    //}
                    Console.WriteLine(step);

                }
                else
                {
                    Console.WriteLine(-1);
                }

            }
        }
    }
}
