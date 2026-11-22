using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchBasic
{
    //Find First and Last Position of Element in Sorted Array
    internal class FindFirstandLastPositionofElement
    {
        //nums = [5, 7, 7, 8, 8, 10]
        //target = 8
        //Output:[3, 4]
        public static int FirstPosition(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;

            int ans = -1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == target)
                {
                    ans = mid;

                    // continue searching left
                    end = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return ans;
        }

        public static int LastPosition(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;

            int ans = -1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == target)
                {
                    ans = mid;

                    // continue searching right
                    start = mid + 1;
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return ans;
        }

    }
}

