using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stack
{
    partial class LargestRectangleinHistogram
    {
        //Input: heights = [2, 1, 5, 6, 2, 3]
        //Output: 10
        public int LargestRectangleArea(int[] heights)
        {
            Stack<int> stk = new Stack<int>();
            int maxArea = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                while (stk.Count > 0 && heights[stk.Peek()] > heights[i])
                {
                    int nse = i;
                    int currval = heights[stk.Pop()];
                    int pse = stk.Count > 0 ? stk.Peek() : -1;
                    int value = (nse - pse - 1) * currval;
                    maxArea = Math.Max(maxArea, value);
                }
                stk.Push(i);
            }
            return maxArea;
        }
    }
}
