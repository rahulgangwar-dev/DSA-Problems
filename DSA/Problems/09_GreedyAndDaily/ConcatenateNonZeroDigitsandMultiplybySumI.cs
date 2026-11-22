using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.GreedyAndDaily
{
    public class ConcatenateNonZeroDigitsandMultiplybySumI
    {
        public long SumAndMultiply(int n)
        {
            long nonZero = 0;
            int place = 1;
            int sum = 0;
            while (n > 0)
            {
                int rem = n % 10;
                if (rem != 0)
                {
                    nonZero += rem * place;
                    sum += rem;
                    place *= 10;
                }
                n /= 10;
            }
            return nonZero * sum;
        }
    }

}
