using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12._1._2
{
    public class ListNode
    {
        // Defined in LeetCode problem
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class SinglyLinkedList
    {
        // Custom Singly-Linked List
        public ListNode Head { get; set; }
        public ListNode Tail { get; set; }

        public SinglyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void Add(int val)
        {
            ListNode newNode = new(val);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }

            Tail.next = newNode;
            Tail = newNode;
        }

        public void FillList(int[] input)
        {
            foreach (int num in input)
            {
                Add(num);
            }
        }

        public string PrintList()
        {
            StringBuilder sb = new();
            ListNode currentNode = Head;            
            
            while (currentNode != null)
            {
                sb.Append(currentNode.val);

                if (currentNode.next != null)
                    sb.Append(",");

                currentNode = currentNode.next;
            }

            return sb.ToString();
        }
    }
}
