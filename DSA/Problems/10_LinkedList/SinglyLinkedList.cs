using System;

namespace DSA.Problems.LinkedList
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

    // partial: har problem apni alag file mein isi class ko extend karta hai
    public partial class SinglyLinkedList
    {
        public Node? Head { get; private set; }

        public void SetHead(Node? node)
        {
            Head = node;
        }

        // ── Add ──
        public void AddFirst(int value)
        {
            var newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(int value)
        {
            var newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var current = Head;
            while (current.Next != null)
                current = current.Next;

            current.Next = newNode;
        }

        // existing ke baad insert
        public void AddMiddle(int newValue, int existing)
        {
            var current = Head;

            while (current != null && current.Data != existing)
                current = current.Next;

            if (current == null)
            {
                Console.WriteLine($"{existing} list mein nahi mila");
                return;
            }

            var newNode = new Node(newValue);
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        // existing se pehle insert (dummy node trick)
        public void AddBefore(int newValue, int existing)
        {
            var dummy = new Node(0);
            dummy.Next = Head;
            var prev = dummy;
            var current = Head;

            while (current != null && current.Data != existing)
            {
                prev = current;
                current = current.Next;
            }

            if (current == null)
            {
                Console.WriteLine($"{existing} list mein nahi mila");
                return;
            }

            var newNode = new Node(newValue);
            newNode.Next = current;
            prev.Next = newNode;

            Head = dummy.Next;
        }

        // ── Delete ──
        public void DeleteFirst()
        {
            if (Head == null) return;
            Head = Head.Next;
        }

        public void DeleteLast()
        {
            if (Head == null) return;

            var dummy = new Node(0);
            dummy.Next = Head;
            var prev = dummy;
            var curr = Head;

            while (curr.Next != null)
            {
                prev = curr;
                curr = curr.Next;
            }

            prev.Next = null;
            Head = dummy.Next;
        }

        public void DeleteValue(int val)
        {
            var dummy = new Node(0);
            dummy.Next = Head;
            var prev = dummy;
            var curr = Head;

            while (curr != null && curr.Data != val)
            {
                prev = curr;
                curr = curr.Next;
            }

            if (curr == null)
            {
                Console.WriteLine($"{val} Element not found.");
                return;
            }

            prev.Next = curr.Next;
            Head = dummy.Next;
        }

        // ── Print full list ──
        public void Print()
        {
            var current = Head;
            while (current != null)
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
