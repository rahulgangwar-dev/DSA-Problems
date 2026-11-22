using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.ArrayBasics
{
    internal class MaximumConsecutiveOnes
    {
        //int[] arr = { 1, 1, 0, 1, 1, 1 };

        //int ans = MaximumConsecutiveOnes.ConsecutiveOnes(arr);
        //Console.Write("Consecutive Ones: "+ ans);
        public static int ConsecutiveOnes(int[] arr)
        {
            int count = 0;
            int ones = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                count = arr[i] == 1 ? count + 1 : 0;
                //if (arr[i] == 0)
                //    count = 0;
                //else
                //    count++;

                ones = Math.Max(ones, count);

            }

            return ones;
        }
    }
}

