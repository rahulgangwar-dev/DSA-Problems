using System;

namespace DSA.Problems.LinkedList
{
    // Palindrome Linked List (LeetCode 234)
    // Input : 1 -> 2 -> 2 -> 1   Output: true
    // Input : 1 -> 2 -> 3        Output: false
    // Approach: slow/fast se second half dhundo -> reverse karo -> compare karo
    //           -> reverse wapas karke original list RESTORE karo
    // Time: O(n)  Space: O(1)
    public partial class SinglyLinkedList
    {
        public bool IsPalindrome()
        {
            if (Head == null || Head.Next == null) return true;

            // Find the start of the second half
            var slow = Head;
            var fast = Head;
            while (fast != null && fast.Next != null)
            {
                slow = slow!.Next;
                fast = fast.Next.Next;
            }
            if (fast != null) slow = slow!.Next;   // odd length: skip the middle node

            var secondHead = ReverseFrom(slow);

            var left = Head;
            var right = secondHead;
            bool result = true;

            while (right != null)
            {
                if (left!.Data != right.Data)
                {
                    result = false;
                    break;
                }
                left = left.Next;
                right = right.Next;
            }

            ReverseFrom(secondHead);   // restore the original list
            return result;
        }

        // Reverses the chain starting at 'start' and returns the new head of that chain
        private static Node? ReverseFrom(Node? start)
        {
            Node? prev = null;
            var current = start;

            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
    }
}
