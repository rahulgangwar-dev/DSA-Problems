using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    public class MyStack
    {
        //Implement Stack using Queues
        Queue<int> input;
        Queue<int> output;
        public MyStack()
        {
            input = new Queue<int>();
            output = new Queue<int>();
        }

        public void Push(int x)
        {
            if (output.Count == 0)
            {
                output.Enqueue(x);
            }
            else
            {
                input = output;
                output = new Queue<int>();
                output.Enqueue(x);
                while (input.Count > 0)
                {
                    output.Enqueue(input.Dequeue());
                }
            }
        }

        public int Pop()
        {
            return output.Dequeue();
        }

        public int Top()
        {
            return output.Peek();
        }

        public bool Empty()
        {
            return input.Count == 0 && output.Count == 0;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}
