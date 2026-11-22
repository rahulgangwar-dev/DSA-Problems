using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.GreedyAndDaily
{
    internal class sumXorr
    {

        public static long sumXor(long n)
        {
            if (n == 0)
            {
                return 1;
            }

            long count = 0;

            while (n > 0)
            {
                if ((n & 1) == 0)
                {
                    count++;
                }
                n = n >> 1;
            }

            return (long)Math.Pow(2, count);
        }

    }
}
