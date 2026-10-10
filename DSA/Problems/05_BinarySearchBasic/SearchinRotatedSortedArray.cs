using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchBasic
{
    internal class SearchinRotatedSortedArray
    {
        //nums = [4,5,6,7,0,1,2]
        //target = 0
        //Output:4
        public static int SearchinRotated(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[start] <= target && target < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid;
                }
            }

            return -1;
        }

    }
}

