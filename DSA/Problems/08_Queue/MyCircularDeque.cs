using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.Queue
{
    public class MyCircularDeque
    {

        /**
         * Your MyCircularDeque object will be instantiated and called as such:
         * MyCircularDeque obj = new MyCircularDeque(k);
         * bool param_1 = obj.InsertFront(value);
         * bool param_2 = obj.InsertLast(value);
         * bool param_3 = obj.DeleteFront();
         * bool param_4 = obj.DeleteLast();
         * int param_5 = obj.GetFront();
         * int param_6 = obj.GetRear();
         * bool param_7 = obj.IsEmpty();
         * bool param_8 = obj.IsFull();
         */
        private int[] arr;
        private int capacity;
        private int size;
        private int front;
        private int rear;
        public MyCircularDeque(int k)
        {
            arr = new int[k];
            capacity = k;
            size = 0;
            front = 0;
            rear = -1;
        }

        public bool InsertFront(int value)
        {
            if (IsFull()) return false;
            if (IsEmpty())
            {
                front = 0;
                rear = 0;
                arr[front] = value;
                size++;
                return true;
            }
            front = (front - 1 + capacity) % capacity;
            arr[front] = value;
            size++;
            return true;
        }

        public bool InsertLast(int value)
        {
            if (IsFull()) return false;
            if (IsEmpty())
            {
                front = 0;
                rear = 0;
                arr[rear] = value;
                size++;
                return true;
            }
            rear = (rear + 1) % capacity;
            arr[rear] = value;
            size++;
            return true;
        }

        public bool DeleteFront()
        {
            if (IsEmpty())
                return false;
            front = (front + 1) % capacity;
            size--;
            return true;
        }

        public bool DeleteLast()
        {
            if (IsEmpty())
                return false;
            rear = (rear - 1 + capacity) % capacity;
            size--;
            return true;
        }

        public int GetFront()
        {
            if (IsEmpty())
                return -1;
            return arr[front];
        }

        public int GetRear()
        {
            if (IsEmpty())
                return -1;
            return arr[rear];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return size == capacity;
        }
    }
}
