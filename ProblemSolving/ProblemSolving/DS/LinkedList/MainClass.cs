using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.DS.LinkedList
{
    internal class MainClass
    {
        static void Main(string[] args)
        {

            var linkedList = new LL();

            linkedList.InsertAtFirst(1);
            linkedList.InsertAtFirst(9);
            linkedList.InsertAtFirst(5);
            linkedList.InsertAtFirst(3);
            linkedList.InsertByRecursion(2, 3);

            linkedList.Display();


            //var Dlist = new DLL();
            //Dlist.InsertAtFirst(8);
            //Dlist.InsertAtFirst(3);
            //Dlist.InsertAtFirst(2);
            //Dlist.InsertAtFirst(5);
            //Dlist.InsertAtLast(17);
            //Dlist.InsertAtIndex(2, 20);
            //Dlist.Display();

            //var cll = new CLL();
            //cll.Insert(8);
            //cll.Insert(9);
            //cll.Insert(2);
            //cll.Insert(7);
            //cll.Display();

            //cll.Display();
            //cll.Delete(7);

            //cll.Display();

        }
    }
}
