using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchBasic
{
    internal class FindFirstandLastPositionofElementinSortedArray
    {
        //Input: nums = [5,7,7,8,8,10], target = 8
        //Output: [3, 4]

        public int[] SearchRange(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int first = -1, second = -1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    first = FindFirst(nums, target, 0, mid);
                    second = FindLast(nums, target, mid, nums.Length - 1);
                    break;
                }
            }
            return new int[] { first, second };
        }

        public int FindFirst(int[] arr, int target, int first, int last)
        {
            int answer = -1;

            while (first <= last)
            {
                int mid = first + (last - first) / 2;
                if (arr[mid] == target)
                {
                    answer = mid;
                    last = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }
            return answer;
        }

        public int FindLast(int[] arr, int target, int first, int last)
        {
            int answer = -1;

            while (first <= last)
            {
                int mid = first + (last - first) / 2;

                if (arr[mid] == target)
                {
                    answer = mid;
                    first = mid + 1;
                }
                else if (arr[mid] < target)
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }

            return answer;
        }
    }
}
