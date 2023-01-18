using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.DS.LinkedList
{
    /// <summary>
    /// Doubly linked list ( Considering tail is not provided)
    /// </summary>
    public class DLL
    {
        private Node head;

        private class Node
        {
            internal int val;
            internal Node next;
            internal Node pre;
            public Node(int val)
            {
                this.val = val;
            }

            public Node(int val, Node next, Node pre) : this(val)
            {
                this.next = next;
                this.pre = pre;
            }
        }



        public void InsertAtFirst(int val)
        {
            var node = new Node(val);

            if (head == null)
            {
                head = node;
                return;
            }
            head.pre = node;
            node.pre = null;
            node.next = head;
            head = node;
        }

        public void InsertAtLast(int val)
        {
            if (head == null)
            {
                InsertAtFirst(val);
            }
            var node = new Node(val);
            node.next = null;
            var lastNode = head;

            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }
            lastNode.next = node;
            node.pre = lastNode;
        }

        public void InsertAtIndex(int index, int val)
        {
            if (index ==0)
            {
                InsertAtFirst(val);
                return;
            }

            var previousNode = head;
            for (int i = 1; i < index; i++)
            {
                previousNode = previousNode.next;
            }

            if (previousNode.next == null)
            {
                InsertAtLast(val); 
                return;
            }

            var node = new Node(val);

            node.next = previousNode.next;
            node.next.pre= node;
            previousNode.next= node;
            node.pre = previousNode;

        }
            public void Display()
        {
            var node = head;
            var last = node;
            while (node != null)
            {
                Console.Write(node.val + " -> ");
                last = node;
                node = node.next;
            }
            Console.Write("END");
            Console.WriteLine();
            Console.WriteLine("Print in reverse");
            while (last != null)
            {
                Console.Write(last.val + " -> ");
                last = last.pre;
            }
            Console.Write("END");
            Console.WriteLine();
        }




    }
}
