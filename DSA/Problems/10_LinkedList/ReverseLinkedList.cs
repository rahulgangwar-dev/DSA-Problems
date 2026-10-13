using System;

namespace DSA.Problems.LinkedList
{
    // Reverse Linked List (LeetCode 206)
    // Input : 1 -> 2 -> 3 -> null
    // Output: 3 -> 2 -> 1 -> null
    // Approach: iterative, 3 pointers (prev, current, next)
    // Time: O(n)  Space: O(1)
    public partial class SinglyLinkedList
    {
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
    }
}
