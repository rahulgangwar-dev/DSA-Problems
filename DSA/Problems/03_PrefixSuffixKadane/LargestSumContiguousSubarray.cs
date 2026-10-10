using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.PrefixSuffixKadane
{
    internal class LargestSumContiguousSubarray
    {
        //Kadane’s Algorithm

        //int[] arr = { -3, -2, -5, -4 };
        //int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        //int[] arr = { 3, -4, 5, 4, -1, 7, -8 };

        //int ans = LargestSumContiguousSubarray.LargestSum(arr);
        //Console.Write("Largest Sum Contiguous Subarray " + ans);


        //int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        public static int LargestSum(int[] arr)
        {
            int currSum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                currSum += arr[i];
                maxSum = Math.Max(currSum, maxSum);
                if (currSum < 0)
                {
                    currSum = 0;
                }
            }
            return maxSum;
        }

        //public static int LargestSum(int[] arr)
        //{
        //    int maxSum = int.MinValue;

        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        int currSum = 0;
        //        for (int j = i; j < arr.Length; j++)
        //        {
        //            currSum += arr[j];
        //            maxSum = Math.Max(maxSum, currSum);

        //        }
        //    }

        //    return maxSum;
        //}


    }
}

