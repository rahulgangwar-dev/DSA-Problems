using System;

namespace DSA.Problems.LinkedList
{
    // Merge Two Sorted Lists (LeetCode 21)
    // Input : 1 -> 3 -> 5   and   2 -> 4 -> 6
    // Output: 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null
    // Approach: dummy node + tail pointer, nodes relink hote hain (no new nodes)
    // Time: O(n + m)  Space: O(1)
    // NOTE: original lists ke nodes reuse hote hain, isliye merge ke baad listA/listB ko use mat karo.
    public partial class SinglyLinkedList
    {
        public static SinglyLinkedList MergeSorted(SinglyLinkedList listA, SinglyLinkedList listB)
        {
            var a = listA.Head;
            var b = listB.Head;
            if (a == null) return listB;
            if (b == null) return listA;

            var dummy = new Node(0);
            var tail = dummy;

            while (a != null && b != null)
            {
                if (a.Data < b.Data)
                {
                    tail.Next = a;
                    a = a.Next;
                }
                else
                {
                    tail.Next = b;
                    b = b.Next;
                }
                tail = tail.Next;
            }
            tail.Next = a ?? b;

            var merged = new SinglyLinkedList();
            merged.SetHead(dummy.Next);
            return merged;
        }
    }
}
