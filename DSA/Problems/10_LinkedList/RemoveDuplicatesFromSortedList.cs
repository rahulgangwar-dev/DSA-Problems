using System;

namespace DSA.Problems.LinkedList
{
    // Remove Duplicates from Sorted List (LeetCode 83)
    // Input : 1 -> 1 -> 2 -> 3 -> 3 -> null
    // Output: 1 -> 2 -> 3 -> null
    // Approach: agar current == next to next ko skip karo, warna aage badho
    // Time: O(n)  Space: O(1)
    public partial class SinglyLinkedList
    {
        public void RemoveDuplicates()
        {
            var current = Head;
            if (current == null) return;

            while (current != null && current.Next != null)
            {
                if (current.Data == current.Next.Data)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
        }
    }
}
