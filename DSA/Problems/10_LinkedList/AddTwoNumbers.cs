using System;

namespace DSA.Problems.LinkedList
{
    // Add Two Numbers (LeetCode 2)
    // Digits reverse order mein stored hain
    // Input : 2 -> 4 -> 3   +   5 -> 6 -> 4      (342 + 465)
    // Output: 7 -> 0 -> 8 -> null                (807)
    // Approach: dummy node + carry; dono lists ek saath chalo, carry bachi ho to ek aur node
    // Result isi list ka Head ban jata hai (naye nodes bante hain, l1/l2 untouched)
    // Time: O(max(n, m))  Space: O(max(n, m))
    public partial class SinglyLinkedList
    {
        public void AddTwoNumbers(Node? l1, Node? l2)
        {
            var dummy = new Node(0);
            var tail = dummy;
            int carry = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                int sum = carry;
                if (l1 != null) { sum += l1.Data; l1 = l1.Next; }
                if (l2 != null) { sum += l2.Data; l2 = l2.Next; }

                tail.Next = new Node(sum % 10);
                carry = sum / 10;

                tail = tail.Next;
            }
            Head = dummy.Next;
        }
    }
}
