using System;

namespace DSA.Problems.LinkedList
{
    // Linked List Cycle (LeetCode 141)
    // Approach: Floyd's tortoise & hare — slow 1 step, fast 2 steps; mile to cycle hai
    // Time: O(n)  Space: O(1)
    public partial class SinglyLinkedList
    {
        public bool HasCycle()
        {
            var slow = Head;
            var fast = Head;
            while (fast != null && fast.Next != null)
            {
                slow = slow!.Next;
                fast = fast.Next.Next;
                if (slow == fast) return true;
            }

            return false;
        }
    }
}
