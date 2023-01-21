using System;
using System.Collections.Generic;
using System.Text;
using static ProblemSolving.LeetCode.LinkedList;

namespace ProblemSolving.LeetCode
{
    public class LLMain
    {
        static void Main(string[] args)
        {
            var ll = new LinkedList();
            var ll2 = new LinkedList();

            //ll.InsertAtFirst(5);
            //ll.InsertAtFirst(3);
            //ll.InsertAtFirst(1);

            //ll2.InsertAtFirst(14);
            //ll2.InsertAtFirst(9);
            //ll2.InsertAtFirst(2);
            //ll2.InsertAtFirst(1);


            //var resultList = new LinkedList();

            //var output = resultList.MergeList(ll, ll2);


            //ll.InsertAtFirst(2);
            //ll.InsertAtFirst(1);
            //ll.InsertAtFirst(1);
            //ll.Display();
            //ll.DeleteDuplicates();
            //ll.Display();

            //ll2.IsHappy(19);

            //ll.InsertAtFirst(6);
            //ll.InsertAtFirst(5);
            //ll.InsertAtFirst(4);
            //ll.InsertAtFirst(3);
            //ll.InsertAtFirst(6);
            //ll.InsertAtFirst(2);
            //ll.InsertAtFirst(1);
            //ll.Display();

            //ll.Remove(6);

            //ll.Display();


            //ll.InsertAtFirst(6);
            //ll.InsertAtFirst(6);
            //ll.InsertAtFirst(6);
            //ll.InsertAtFirst(6);
            //ll.Display();

            //ll.Remove(6);

            //ll.Display();


            ll.InsertAtFirst(1);
            ll.InsertAtFirst(2);
            ll.InsertAtFirst(2);
            ll.InsertAtFirst(1);
            ll.Display();

            ll.Remove(2);

            ll.Display();


        }

    }
}
