using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Problems.LinkedList
{
    public class ReverseNodesInKGroup
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

        //Input: 1 -> 2 -> 3 -> 4 -> 5, k = 2
        //Output: 2 -> 1 -> 4 -> 3 -> 5
        public static Node? ReverseinKGroups(Node? head, int k)
        {
            var dummy = new Node(0);
            dummy.Next = head;
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

            return dummy.Next;
        }
    }
}
