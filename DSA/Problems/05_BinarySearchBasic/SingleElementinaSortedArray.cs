using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchBasic
{
    internal class SingleElementinaSortedArray
    {
        //Input: nums = [1,1,2,3,3,4,4,8,8]
        //Output: 2 

        public int SingleNonDuplicate(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (mid % 2 == 1)
                {
                    mid--;
                }
                if (nums[mid] == nums[mid + 1])
                    start = mid + 2;
                else
                    end = mid;
            }
            return nums[start];
        }
    }
}
