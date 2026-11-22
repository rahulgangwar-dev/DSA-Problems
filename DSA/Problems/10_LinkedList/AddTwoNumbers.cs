using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Problems.LinkedList
{
    public class AddTwoNumbers
    {
        public class Node
        {
            public int Data { get; set; }
            public Node? Next { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        //Input: l1 = 2 -> 4 -> 3, l2 = 5 -> 6 -> 4
        //Output: 7 -> 0 -> 8
        public static Node? Add(Node? l1, Node? l2)
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
            return dummy.Next;
        }
    }
}
