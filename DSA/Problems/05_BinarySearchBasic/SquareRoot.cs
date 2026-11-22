using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchBasic
{
    internal class SquareRoot
    {

        //int v = int.MaxValue;
        //int value = 15;
        //int ans = SquareRoot.Root(value);
        //Console.WriteLine("Root: " + ans);

        //Output:- 16
        public static int Root(int value)
        {
            if (value < 2)
            {
                return value;
            }

            int low = 1;
            int high = value;
            int ans = 0;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (mid * mid <= value)
                {
                    ans = mid;
                    low = mid+1;
                }
                else
                {
                    high = mid-1;
                }
            }

            return ans;
        }


    }
}
