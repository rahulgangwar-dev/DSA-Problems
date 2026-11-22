using System;

namespace DSA.Problems.LinkedList
{
    // Reorder List (LeetCode 143)
    // Input : 1 -> 2 -> 3 -> 4 -> 5
    // Output: 1 -> 5 -> 2 -> 4 -> 3 -> null
    //
    // ⚠️ BOTH attempts below are copied as-is from LinkedList1.cs — see NOTEs.
    // Optimal plan (find middle -> reverse second half -> merge alternately) is
    // not finished yet; draft was only a comment at the bottom of LinkedList1.cs.
    public partial class SinglyLinkedList
    {
        // Attempt 1 (optimal idea) — NOTE: INCOMPLETE / BROKEN.
        // `middle` kabhi use nahi hota, second half reverse nahi hota, aur loop
        // pointers ko cycle mein badal deta hai (e.g. 1,2,3,4 pe infinite loop). Don't call.
        public void ReorderList()
        {
            var dummy = new Node(0);
            dummy.Next = Head;
            var middle = Head;
            var fast = Head;
            while (fast != null && fast.Next != null && fast.Next.Next != null)
            {
                middle = middle!.Next;
                fast = fast.Next.Next;
            }
            if (fast == null) middle = middle!.Next;

            while (Head != null && Head.Next != null && Head.Next.Next != null)
            {
                var next = Head.Next;
                Head.Next = Head.Next.Next;
                Head.Next.Next = next;
                Head = next;
            }
            Head = dummy.Next;
        }

        // Attempt 2 (brute force) — har round mein last node pakad ke aage laata hai
        // Time: O(n^2)  Space: O(1)
        // NOTE: ODD length (1..5) pe sahi chalta hai. EVEN length (e.g. 1,2,3,4) pe
        // last round mein node apne aap ko point karne lagta hai -> infinite loop.
        // (Original name was ReorderListBrote — renamed, typo only.)
        public void ReorderListBrute()
        {
            var dummy = new Node(0);
            dummy.Next = Head;
            while (Head != null && Head.Next != null)
            {
                var next = Head.Next;
                var lastsecond = Head;
                while (lastsecond != null && lastsecond.Next != null && lastsecond.Next.Next != null)
                {
                    lastsecond = lastsecond.Next;
                }
                var last = lastsecond!.Next;
                lastsecond.Next = null;
                Head.Next = last;
                last!.Next = next;
                Head = next;
            }
            Head = dummy.Next;
        }
    }
}
