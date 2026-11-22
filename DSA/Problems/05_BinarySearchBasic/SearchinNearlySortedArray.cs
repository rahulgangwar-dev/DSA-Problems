using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchBasic
{
    internal class SearchinNearlySortedArray
    {
        //int[] v = [10, 3, 20, 40, 50, 80, 70];
        //int value = 70;
        //int ans = SearchinNearlySortedArray.IndexOfElement(v, value);
        //Console.WriteLine("Index: " + ans);
        public static int IndexOfElement(int[] arr,int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (mid < high && arr[mid+1] == target)
                {
                    return mid + 1;
                }
                else if (mid > low && arr[mid-1] == target)
                {
                    return mid - 1;
                }
                else if (arr[mid] > target)
                {
                    high = mid - 2;
                }
                else
                {
                    low = mid + 2;
                }
            }
            return -1;

        }
    }
}
