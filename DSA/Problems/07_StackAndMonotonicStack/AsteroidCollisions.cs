using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.StackAndMonotonicStack
{
    partial class AsteroidCollisions
    {
        //Input: asteroids = [5, 10, -5]
        //Output: [5, 10]
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stk = new Stack<int>();

            for (int i = 0; i < asteroids.Length; i++)
            {
                bool destroyed = false;

                while (stk.Count > 0 &&
                       stk.Peek() > 0 &&
                       asteroids[i] < 0)
                {
                    int top = stk.Peek();
                    int current = Math.Abs(asteroids[i]);

                    if (top < current)
                    {
                        stk.Pop();
                    }
                    else if (top > current)
                    {
                        destroyed = true;
                        break;
                    }
                    else
                    {
                        stk.Pop();
                        destroyed = true;
                        break;
                    }
                }

                if (!destroyed)
                {
                    stk.Push(asteroids[i]);
                }
            }

            int[] result = new int[stk.Count];

            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = stk.Pop();
            }

            return result;
        }
    }
}
