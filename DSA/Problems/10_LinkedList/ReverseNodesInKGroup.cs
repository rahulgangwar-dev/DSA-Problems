using System;

namespace DSA.Problems.LinkedList
{
    // Reverse Nodes in k-Group (LeetCode 25)
    // Input : 1 -> 2 -> 3 -> 4 -> 5, k = 2
    // Output: 2 -> 1 -> 4 -> 3 -> 5 -> null   (last incomplete group jaisa hai waisa rehta hai)
    // Approach: dummy node; har group ke liye kth node dhundo, group reverse karo, relink karo
    // Time: O(n)  Space: O(1)
    public partial class SinglyLinkedList
    {
        public Node? ReverseinKGroups(int k)
        {
            var dummy = new Node(0);
            dummy.Next = Head;
            var groupPrev = dummy;

            while (true)
            {
                var kth = groupPrev;
                for (int i = 0; i < k && kth != null; i++)
                    kth = kth.Next;
                if (kth == null) break;

                var groupStart = groupPrev.Next;
                var grouptail = groupStart;
                Node? prev1 = null;
                int j = 0;
                while (groupStart != null && j < k)
                {
                    var next = groupStart.Next;
                    groupStart.Next = prev1;

                    prev1 = groupStart;
                    groupStart = next;
                    j++;
                }
                grouptail!.Next = groupStart;
                groupPrev.Next = kth;
                groupPrev = grouptail;
            }

            Head = dummy.Next;   // added: Head update, taaki list.Print() sahi dikhaye
            return dummy.Next;
        }
    }
}
