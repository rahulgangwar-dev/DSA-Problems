using System;

namespace DSA.Problems.LinkedList
{
    // Reverse Linked List (LeetCode 206)
    // Input : 1 -> 2 -> 3 -> null
    // Output: 3 -> 2 -> 1 -> null
    public partial class SinglyLinkedList
    {
        // Approach 1: iterative, 3 pointers (prev, current, next)
        // Time: O(n)  Space: O(1)
        public void Reverse()
        {
            Node? prev = null;
            var current = Head;

            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Head = prev;
        }

        // Approach 2: recursive
        // Time: O(n)  Space: O(n) — recursion stack
        public void ReverseRecursive()
        {
            Head = ReverseRecursive(Head);
        }

        private Node? ReverseRecursive(Node? head)
        {
            if (head == null || head.Next == null)
                return head;

            var newHead = ReverseRecursive(head.Next);

            head.Next.Next = head;
            head.Next = null;

            return newHead;
        }
    }
}
