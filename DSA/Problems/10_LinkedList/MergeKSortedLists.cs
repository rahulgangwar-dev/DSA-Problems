using System;

namespace DSA.Problems.LinkedList
{
    // Merge k Sorted Lists (LeetCode 23)
    // Input : [1->4->6, 2->5->7, ...]
    //
    // ⚠️ WORK IN PROGRESS — copied as-is from LinkedList1.cs. NOTE:
    //  - `lists` parameter use hi nahi hota; do lists hardcode hain
    //  - `first.Next` do baar assign hota hai, isliye 4 / 5 overwrite ho jate hain
    //    (first = 1->6, second = 2->7)
    //  - actually sirf 2 lists merge karta hai, k lists nahi
    // Real solution: min-heap (PriorityQueue) ya pairwise MergeSorted — baad mein likhna hai.
    public partial class SinglyLinkedList
    {
        public Node? MergeKLists(Node[] lists)
        {
            Node? first = new Node(1);
            first.Next = new Node(4);
            first.Next = new Node(6);
            Node? second = new Node(2);
            second.Next = new Node(5);
            second.Next = new Node(7);

            var dummy = new Node(0);
            var current = dummy;
            while (first != null && second != null)
            {
                if (first.Data > second.Data)
                {
                    current.Next = second;
                    second = second.Next;
                }
                else
                {
                    current.Next = first;
                    first = first.Next;
                }
                current = current.Next;
            }

            if (first != null) current.Next = first;
            else current.Next = second;

            return dummy.Next;
        }
    }
}
