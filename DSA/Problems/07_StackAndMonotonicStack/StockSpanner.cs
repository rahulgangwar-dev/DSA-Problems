using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.StackAndMonotonicStack
{
    partial class StockSpanner
    {
        Stack<(int price, int index)> stk;
        int i = 0;
        public StockSpanner()
        {
            stk = new Stack<(int, int)>();
        }

        public int Next(int price)
        {
            i++;
            if (stk.Count == 0)
            {
                stk.Push((price, i));
                return 1;
            }
            else
            {
                while (stk.Count > 0 && stk.Peek().price <= price)
                {
                    stk.Pop();
                }
                int ans = stk.Count == 0 ? i : i - stk.Peek().index;
                stk.Push((price, i)); 
                return ans;
            }
        }
    }
}
