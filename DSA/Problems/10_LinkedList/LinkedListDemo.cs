using System;

namespace DSA.Problems.LinkedList
{
    // Manual tests — Program.cs se LinkedListDemo.RunAll() call karo
    public static class LinkedListDemo
    {
        public static void RunAll()
        {
            TestAddMethods();
            TestDeleteMethods();
            TestEdgeCases();
            TestAdvanced();
            TestNewProblems();
        }

        static void TestAddMethods()
        {
            Console.WriteLine("═══════ ADD METHODS ═══════");
            var list = new SinglyLinkedList();

            list.AddLast(10); list.AddLast(20); list.AddLast(30);
            Console.Write("AddLast(10,20,30):  "); list.Print();   // 10 -> 20 -> 30 -> null

            list.AddFirst(5);
            Console.Write("AddFirst(5):        "); list.Print();   // 5 -> 10 -> 20 -> 30 -> null

            list.AddMiddle(25, 20);
            Console.Write("AddMiddle(25, 20):  "); list.Print();   // 5 -> 10 -> 20 -> 25 -> 30 -> null

            list.AddBefore(3, 5);
            Console.Write("AddBefore(3, 5):    "); list.Print();   // head case

            list.AddBefore(15, 20);
            Console.Write("AddBefore(15, 20):  "); list.Print();   // middle case

            list.AddBefore(99, 999);
            Console.Write("AddBefore(99, 999): "); list.Print();   // not found + message
            Console.WriteLine();
        }

        static void TestDeleteMethods()
        {
            Console.WriteLine("═══════ DELETE METHODS ═══════");
            var list = new SinglyLinkedList();
            list.AddLast(10); list.AddLast(20); list.AddLast(30); list.AddLast(40);

            list.DeleteFirst();
            Console.Write("DeleteFirst():      "); list.Print();   // 20 -> 30 -> 40 -> null

            list.DeleteLast();
            Console.Write("DeleteLast():       "); list.Print();   // 20 -> 30 -> null

            list.DeleteValue(30);
            Console.Write("DeleteValue(30):    "); list.Print();   // 20 -> null

            list.DeleteValue(999);
            Console.Write("DeleteValue(999):   "); list.Print();   // not found + message
            Console.WriteLine();
        }

        static void TestEdgeCases()
        {
            Console.WriteLine("═══════ EDGE CASES ═══════");

            var single = new SinglyLinkedList();
            single.AddLast(10);
            single.DeleteLast();
            Console.Write("Single → DeleteLast: "); single.Print();   // null

            var empty = new SinglyLinkedList();
            empty.DeleteFirst(); empty.DeleteLast(); empty.DeleteValue(10);
            empty.AddBefore(5, 10); empty.AddMiddle(5, 10);
            Console.Write("Empty → all ops:     "); empty.Print();    // null
            Console.WriteLine();
        }

        static void TestAdvanced()
        {
            Console.WriteLine("═══════ ADVANCED ═══════");

            var list = new SinglyLinkedList();
            foreach (var v in new[] { 1, 2, 3, 4, 5 }) list.AddLast(v);
            Console.WriteLine($"Middle (slow/fast): {list.FindMiddle()?.Data}");        // 3
            Console.WriteLine($"Middle (count):     {list.FindMiddleCount()?.Data}");   // 3

            list.Reverse();
            Console.Write("Reverse:            "); list.Print();   // 5 -> 4 -> 3 -> 2 -> 1 -> null

            var dup = new SinglyLinkedList();
            foreach (var v in new[] { 1, 1, 2, 3, 3 }) dup.AddLast(v);
            dup.RemoveDuplicates();
            Console.Write("RemoveDuplicates:   "); dup.Print();   // 1 -> 2 -> 3 -> null

            var a = new SinglyLinkedList(); a.AddLast(1); a.AddLast(3); a.AddLast(5);
            var b = new SinglyLinkedList(); b.AddLast(2); b.AddLast(4); b.AddLast(6);
            var merged = SinglyLinkedList.MergeSorted(a, b);
            Console.Write("MergeSorted:        "); merged.Print();   // 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null

            Console.WriteLine($"HasCycle (no cycle): {merged.HasCycle()}");   // False

            // cycle banao: last.Next = second node
            var cyc = new SinglyLinkedList();
            foreach (var v in new[] { 1, 2, 3, 4 }) cyc.AddLast(v);
            var second = cyc.Head!.Next!;
            var last = cyc.Head;
            while (last!.Next != null) last = last.Next;
            last.Next = second;
            Console.WriteLine($"HasCycle (cycle):    {cyc.HasCycle()}");      // True
            Console.WriteLine();
        }

        static SinglyLinkedList Build(params int[] values)
        {
            var l = new SinglyLinkedList();
            foreach (var v in values) l.AddLast(v);
            return l;
        }

        static void TestNewProblems()
        {
            Console.WriteLine("═══════ NEW PROBLEMS ═══════");

            var rr = Build(1, 2, 3, 4, 5);
            rr.ReverseRecursive();
            Console.Write("ReverseRecursive:   "); rr.Print();   // 5 -> 4 -> 3 -> 2 -> 1 -> null

            var nth = Build(1, 2, 3, 4, 5);
            Console.WriteLine($"NthFromEnd(2):      {nth.NthFromEnd(2)?.Data}");        // 4
            Console.WriteLine($"NthFromEndCount(2): {nth.NthFromEndCount(2)?.Data}");   // 4

            var rm = Build(1, 2, 3, 4, 5);
            rm.RemoveNthFromEnd(2);
            Console.Write("RemoveNthFromEnd(2):"); rm.Print();   // 1 -> 2 -> 3 -> 5 -> null
            var rmHead = Build(1, 2, 3, 4, 5);
            rmHead.RemoveNthFromEnd(5);
            Console.Write("RemoveNthFromEnd(5):"); rmHead.Print();   // 2 -> 3 -> 4 -> 5 -> null (head case)

            Console.WriteLine($"IsPalindrome 1,2,2,1: {Build(1, 2, 2, 1).IsPalindrome()}");   // True
            Console.WriteLine($"IsPalindrome 1,2,3:   {Build(1, 2, 3).IsPalindrome()}");      // False

            var kg = Build(1, 2, 3, 4, 5);
            kg.ReverseinKGroups(2);
            Console.Write("ReverseinKGroups(2):"); kg.Print();   // 2 -> 1 -> 4 -> 3 -> 5 -> null

            var ro = Build(1, 2, 3, 4, 5);   // odd length only — even length pe infinite loop (see ReorderList.cs)
            ro.ReorderListBrute();
            Console.Write("ReorderListBrute:   "); ro.Print();   // 1 -> 5 -> 2 -> 4 -> 3 -> null

            var a = Build(2, 4, 3);
            var b = Build(5, 6, 4);
            var sum = new SinglyLinkedList();
            sum.AddTwoNumbers(a.Head, b.Head);
            Console.Write("AddTwoNumbers:      "); sum.Print();   // 7 -> 0 -> 8 -> null
            Console.WriteLine();
        }
    }
}
