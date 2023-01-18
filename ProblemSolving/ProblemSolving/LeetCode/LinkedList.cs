using ProblemSolving.DS.LinkedList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ProblemSolving.LeetCode
{
    public class LinkedList
    {
        private ListNode head;
        private ListNode tail;
        private int size;

        public class ListNode
        {
            internal int val;
            internal ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public void InsertAtFirst(int val)
        {
            var node = new ListNode(val);
            node.next = head;
            head = node;
            if (tail == null)
            {
                tail = head;
            }

            size += 1;
        }

        public void InsertAtLast(int val)
        {
            if (tail == null)
            {
                InsertAtFirst(val);
                return;
            }

            var node = new ListNode(val);
            tail.next = node;
            tail = node;
            size++;
        }

        public ListNode DeleteDuplicates()
        {
            var node = head;
            while (node.next != null)
            {
                if (node.val == node.next.val)
                {
                    node.next = node.next.next;
                }
                else
                {

                    node = node.next;
                }
            }
            return node;
        }


        public ListNode MergeList(LinkedList list1, LinkedList list2)
        {
            var result = Merge(list1.head, list2.head);
            return result;
        }

        public ListNode Merge(ListNode first, ListNode second)
        {

            var ansLL = new LinkedList();

            while (first != null && second != null)
            {
                if (first.val < second.val)
                {
                    ansLL.InsertAtLast(first.val);
                    first = first.next;
                }
                else
                {
                    ansLL.InsertAtLast(second.val);
                    second = second.next;
                }
            }


            while (second != null)
            {
                ansLL.InsertAtLast(second.val);
                second = second.next;
            }


            while (first != null)
            {
                ansLL.InsertAtLast(first.val);
                first = first.next;
            }


            return ansLL.head;
        }

        public void Display()
        {
            ListNode tempNode = head;

            while (tempNode != null)
            {
                Console.Write(tempNode.val + " -> ");
                tempNode = tempNode.next;
            }
            Console.Write("END");
            Console.WriteLine();
        }

    }


}



