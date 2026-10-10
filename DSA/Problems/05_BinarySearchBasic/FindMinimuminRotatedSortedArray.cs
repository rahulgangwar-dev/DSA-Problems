using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchBasic
{
    internal class FindMinimuminRotatedSortedArray
    {
        //Problem 35. Find Minimum in Rotated Sorted Array

        //int[] nums = [4, 5, 6, 7, 0, 1, 2];

        //int ans = FindMinimuminRotatedSortedArray.MinimumRotated(nums);
        //Console.Write("Min Element: " + ans);
        public static int MinimumRotated(int[] arr)
        {
        //[4, 5, 6, 7, 0, 1, 2]
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] > arr[end])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            return start;
        }

    }
}
