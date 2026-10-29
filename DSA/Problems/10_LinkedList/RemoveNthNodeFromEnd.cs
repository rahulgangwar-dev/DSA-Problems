using System;

namespace DSA.Problems.LinkedList
{
    // Remove Nth Node From End of List (LeetCode 19)
    // Input : 1 -> 2 -> 3 -> 4 -> 5, n = 2
    // Output: 1 -> 2 -> 3 -> 5 -> null
    // Approach: dummy node + two pointers; fast n steps aage, phir dono saath chalo
    //           slow target se JUST PEHLE ruk jata hai (head delete bhi handle hota hai)
    // Time: O(n)  Space: O(1)
    public partial class SinglyLinkedList
    {
        // Removes the nth node from the end. Returns the new Head.
        public Node? RemoveNthFromEnd(int n)
        {
            if (Head == null || n <= 0) return Head;

            var dummy = new Node(0);
            dummy.Next = Head;
            var slow = dummy;
            var fast = dummy;

            // Move fast n steps ahead
            for (int i = 0; i < n; i++)
            {
                if (fast.Next == null) return Head;   // n larger than list length
                fast = fast.Next;
            }

            // Move both until fast is on the last node; slow is then just BEFORE the target
            while (fast.Next != null)
            {
                slow = slow.Next!;
                fast = fast.Next;
            }

            slow.Next = slow.Next!.Next;
            Head = dummy.Next;
            return Head;
        }
    }
}
