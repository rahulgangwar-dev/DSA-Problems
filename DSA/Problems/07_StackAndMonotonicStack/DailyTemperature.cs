using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.StackAndMonotonicStack
{
    partial class DailyTemperature
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<int> stk = new Stack<int>();

            int[] answer = new int[temperatures.Length];

            for (int i = 0; i < temperatures.Length; i++)
            {

                while (stk.Count > 0 && temperatures[stk.Peek()] < temperatures[i])
                {
                    int val = stk.Pop();
                    int t = i - val;
                    answer[val] = t;
                }
                stk.Push(i);
            }
            while (stk.Count > 0)
            {
                answer[stk.Pop()] = 0;
            }
            return answer;
        }
    }
}
