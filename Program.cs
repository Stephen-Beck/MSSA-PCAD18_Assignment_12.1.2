/*
// Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
 }
 
public class Solution
{
    public bool IsPalindrome(ListNode current)
    {

    }
}
*/

/*
Given the current of a singly linked list, return true if it is a palindrome or false otherwise.

    Example 1:
        (1)->(2)->(2)->(1)
        Input: current = [1,2,2,1]
        Output: true

    Example 2:
        (1)->(2)
        Input: current = [1,2]
        Output: false
*/

namespace Assignment_12._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] head = new int[] { 1, 2, 2, 1 };
            Test(head); //true

            head = new int[] { 1, 2 };
            Test(head); //false

            // Additional test cases
            head = new int[] { 1, 2, 3, 2, 1 };
            Test(head); //true

            head = new int[] { 1, 2, 3, 3, 1 };
            Test(head); //false

            head = new int[] { };
            Test(head); //true

            head = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Test(head); //false

            head = new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
            Test(head); //true
        }

        public static bool IsPalindrome(ListNode head)
        {
            #region Second Attempt (LeetCode Runtime: 4ms)
            // This was my first idea for a solution, but it feels like cheating using a List to hold a Singly-Linked List!
            List<int> list = new();
            
            // Fill list
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            // Compare left and right
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                if (list[left++] != list[right--]) return false;
            }

            return true;
            #endregion

            #region First Attempt (LeetCode Runtime: 13ms)
            Stack<int> listStack = new();
            ListNode current = head;

            // Fill stack
            while (current != null)
            {
                listStack.Push(current.val);
                current = current.next;
            }

            // Compare list with stack
            current = head;
            while (current != null)
            {
                if (current.val != listStack.Pop()) return false;
                else current = current.next;
            }

            return true; 
            #endregion
        }

        public static void Test(int[] head)
        {
            // helper function to help keep Main() cleaner

            // Create and fill Singly-Linked List
            SinglyLinkedList sll = new();
            sll.FillList(head);

            // Print Input
            Console.WriteLine($"Input: head = [{sll.PrintList()}]");

            // Print Output (checking IsPalindrome)
            Console.WriteLine($"Output: {IsPalindrome(sll.Head)}\n");
        }
    }
}
