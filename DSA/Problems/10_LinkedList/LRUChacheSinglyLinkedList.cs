using System;

namespace DSA.Problems.LinkedList
{
    public class ListNode
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public ListNode? Next { get; set; }

        public ListNode(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    public class LRUCache
    {
        private int capacity;
        private Dictionary<int, ListNode> map;
        private ListNode? head;
        private ListNode? tail;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            map = new Dictionary<int, ListNode>();
            head = null;
            tail = null;
        }

        public int Get(int key)
        {
            if (!map.ContainsKey(key)) return -1;

            var node = map[key];
            MoveToHead(node);
            return node.Value;
        }

        public void Put(int key, int value)
        {
            if (map.ContainsKey(key))
            {
                ListNode n = map[key];
                n.Value = value;
                MoveToHead(n);
                return;
            }

            var newNode = new ListNode(key, value);
            AddToHead(newNode);
            map[key] = newNode;

            if (map.Count > capacity)
            {
                var lru = tail;
                map.Remove(lru.Key);
                RemoveNode(lru);
            }
        }

        private void AddToHead(ListNode node)
        {
            if (head == null) tail = node;
            node.Next = head;
            head = node;
        }

        private void RemoveNode(ListNode node)
        {
            if (node == head)
            {
                head = head.Next;
                if (head == null) tail = null;
                return;
            }

            ListNode prev = head;
            while (prev != null && prev.Next != node)
                prev = prev.Next;

            if (prev != null && prev.Next == node)
                prev.Next = node.Next;

            if (node == tail)
                tail = prev;
        }

        private void MoveToHead(ListNode node)
        {
            RemoveNode(node);
            AddToHead(node);
        }
    }
}
