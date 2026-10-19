using System;

namespace DSA.Problems.LinkedList
{
    // Nth Node From End
    // Input : 1 -> 2 -> 3 -> 4 -> 5, n = 2
    // Output: node with Data 4
    // n list ki length se bada ho (ya n <= 0) to null return hota hai
    public partial class SinglyLinkedList
    {
        // Approach 1: two pointers — fast n steps aage, phir dono saath chalo
        // Time: O(n)  Space: O(1)
        public Node? NthFromEnd(int n)
        {
            if (Head == null || n <= 0) return null;

            var fast = Head;
            var slow = Head;

            while (n > 0 && fast != null)
            {
                fast = fast.Next;
                n--;
            }
            if (n > 0) return null;   // n is larger than list length

            while (fast != null)
            {
                fast = fast.Next;
                slow = slow!.Next;
            }

            return slow;
        }

        // Approach 2: count nodes, phir (count - n) steps chalo — two passes
        // Time: O(n)  Space: O(1)
        public Node? NthFromEndCount(int n)
        {
            if (n <= 0) return null;

            var current = Head;
            int count = 0;
            while (current != null)
            {
                current = current.Next;
                count++;
            }

            if (count < n) return null;

            int index = count - n;
            current = Head;
            while (index > 0)
            {
                current = current!.Next;
                index--;
            }

            return current;
        }
    }
}
