using System;

namespace DSA.Problems.LinkedList
{
    public class DNode
    {
        public int Data { get; set; }
        public DNode? Next { get; set; }
        public DNode? Back { get; set; }

        public DNode(int data, DNode next = null, DNode back = null)
        {
            Data = data;
            Next = next;
            Back = back;
        }

    }

    public class DLinkedList
    {
        int[] arr = { 2, 5, 4, 7, 1 };

        public DNode Head { get; set; }
        public DNode? Tail { get; set; }
        public DNode ConvertArr2DLL(int[] arr)
        {
            Head = new DNode(arr[0]);
            DNode prev = Head;
            for (int i = 1; i < arr.Length; i++)
            {
                DNode newNode = new DNode(arr[i], null, prev);
                prev.Next = newNode;
                prev = newNode;
            }
            Tail = prev;

            return Head;
        }

        public void RemoveHead()
        {
            if (Head == null)
                return;

            Head = Head.Next;
            if (Head != null)
                Head.Back = null;
        }

        public void RemoveTail()
        {
            if (Tail == null) return;

            if (Tail.Back == null)
            {
                Head = null;
                Tail = null;
                return;
            }

            Tail = Tail.Back;
            Tail.Next = null;
        }

        //1,2,3,4
        public void RemoveKthNode(int k)
        {
            DNode temp = Head;
            int cnt = 0;


            while (temp != null && cnt < k)
            {
                temp = temp.Next;
                cnt++;
            }

            if (temp == null) return;
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
                return;
            }

            if (temp.Back == null)
            {
                Head = temp.Next;
                Head.Back = null;
            }
            else if (temp.Next == null)
            {
                Tail = temp.Back;
                Tail.Next = null;
            }
            else
            {
                //1,2,3,4
                var prevNode = temp.Back;
                var nextNode = temp.Next;
                prevNode.Next = nextNode;
                nextNode.Back = prevNode;
            }

        }

        public void Print()
        {
            DNode? temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " <-> ");
                temp = temp.Next;
            }

            Console.WriteLine("null");
        }

        public void InsertBeforeHead(DNode node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            node.Next = Head;
            Head.Back = node;
            Head = node;
        }

        public void InsertBeforeTail(DNode node)
        {
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            if (Head == Tail)
            {
                InsertBeforeHead(node);
                return;
            }

            DNode prev = Tail.Back;

            prev.Next = node;
            node.Back = prev;
            node.Next = Tail;
            Tail.Back = node;
        }
        public void InsertBeforeKthElement(int k, DNode node)
        {
            if (Head == null || k <= 0) return;
            if (k == 1)
            {
                InsertBeforeHead(node); 
                return;
            }

            DNode temp = Head;
            int cnt = 1;

            while (temp != null && cnt < k - 1)
            {
                temp = temp.Next;
                cnt++;
            }

            if (temp == null || temp.Next == null)
            {
                if (temp != null && temp.Next == null && cnt == k - 1)
                {
                    InsertBeforeTail(node);
                }
                return;
            }

            DNode nextNode = temp.Next;

            temp.Next = node;
            node.Back = temp;
            node.Next = nextNode;
            nextNode.Back = node;

        }

        public void Test()
        {
            int[] arr = { 2, 5, 8, 4, 6, 7, 1 };

            DNode? head = ConvertArr2DLL(arr);
            Print();

            RemoveHead();
            Print();

            DNode n = new DNode(9);
            InsertBeforeHead(n);
            Print();


            //RemoveHead();
            //Print();

            //RemoveTail();
            //Print();

            //RemoveKthNode(2);
            //Print();
        }

    }
}


//Doubly Linked List Operations:
//☑ Convert Array to DLL
//☑ RemoveHead, RemoveTail