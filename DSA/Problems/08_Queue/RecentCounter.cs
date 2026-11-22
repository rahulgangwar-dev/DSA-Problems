using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.Queue
{
    public class RecentCounter
    {
        Queue<int> q;
        public RecentCounter()
        {
            q = new Queue<int>();
        }

        public int Ping(int t)
        {
            q.Enqueue(t);
            while (q.Peek() < t - 3000)
            {
                q.Dequeue();
            }

            return q.Count;
        }
    }
}
