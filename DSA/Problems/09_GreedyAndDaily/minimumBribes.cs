using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.GreedyAndDaily
{
    internal class minimumBribes
    {
        public static void minimumBribess(List<int> q)
        {
            int bribes = 0;
            for (int i = 0; i < q.Count; i++)
            { 
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                 
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i])
                    {
                        bribes++;
                    }
                }
            }
            Console.WriteLine(bribes);
        }
    }
}
