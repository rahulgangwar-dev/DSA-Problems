using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class MyQueue
    {
        //Implement Queue using Stacks
        Stack<int> stk1;
        Stack<int> stk2;

        public MyQueue()
        {
            stk1 = new Stack<int>();
            stk2 = new Stack<int>();
        }

        public void Push(int x)
        {
            stk1.Push(x);
        }

        public int Pop()
        {
            MoveToStack2();

            return stk2.Pop();
        }

        public int Peek()
        {
            MoveToStack2();

            return stk2.Peek();
        }

        public bool Empty()
        {
            return stk1.Count == 0 && stk2.Count == 0;
        }

        private void MoveToStack2()
        {
            if (stk2.Count == 0)
            {
                while (stk1.Count > 0)
                {
                    stk2.Push(stk1.Pop());
                }
            }
        }
    }
}
