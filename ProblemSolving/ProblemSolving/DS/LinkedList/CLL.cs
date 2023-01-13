using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.DS.LinkedList
{
    public class CLL
    {
        private Node head;
        private Node tail;

        private class Node
        {
            internal int val;
            internal Node next;

            public Node(int val)
            {
                this.val = val;
            }
        }

        public void Insert(int val)
        {
            var node = new Node(val);
            if (head == null)
            {
                head = node;
                tail = node;
                return;
            }
            tail.next = node;
            node.next = head;
            tail = node;
        }

        public void Delete(int val)
        {
            var node = head;

            if (node.val == val)
            {
                head = head.next;
                tail.next = head;
                return;
            }

            do
            {
                if (node.next.val == val)
                {
                    node.next = node.next.next;
                    break;
                }
                node = node.next;
            } while (node != head);
            
        }

        public void Display()
        {
            var node = head;
            do
            {
                Console.Write(node.val + " -> ");
                node = node.next;

            } while (node != head);

            Console.Write("END");
            Console.WriteLine();
        }


    }
}
