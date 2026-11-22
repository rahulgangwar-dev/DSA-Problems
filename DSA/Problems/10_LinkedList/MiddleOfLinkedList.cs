using System;

namespace DSA.Problems.LinkedList
{
    // Middle of the Linked List (LeetCode 876-style)
    // 1,2,3,4,5   -> 3
    // 1,2,3,4     -> 2  (first middle; LeetCode 876 expects 3, the second middle)
    public partial class SinglyLinkedList
    {
        // Approach 1: slow / fast pointer — single pass
        // Time: O(n)  Space: O(1)
        public Node? FindMiddle()
        {
            var slow = Head;
            var fast = Head;
            while (fast?.Next?.Next != null)
            {
                slow = slow!.Next;
                fast = fast.Next.Next;
            }
            return slow;
        }

        // Approach 2: count nodes, phir (count-1)/2 steps chalo — two passes
        // Time: O(n)  Space: O(1)
        public Node? FindMiddleCount()
        {
            int count = 0;
            var current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            current = Head;

            int steps = (count - 1) / 2;
            for (int i = 0; i < steps; i++)
            {
                current = current!.Next;
            }
            return current;
        }
    }
}
