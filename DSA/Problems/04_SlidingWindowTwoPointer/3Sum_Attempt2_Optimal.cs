using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.SlidingWindowTwoPointer
{
    internal class e3Sum
    {
        //Input: nums = [-1,0,1,2,-1,-4]
        //Output: [[-1,-1,2],[-1,0,1]]
        //Explanation: 
        //nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        //nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        //nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        //The distinct triplets are[-1, 0, 1] and[-1, -1, 2].
        //Notice that the order of the output and the order of the triplets does not matter.

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> lst = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum < 0)
                        left++;
                    else if (sum > 0)
                        right--;
                    else
                    {
                        lst.Add(new List<int>
                       {
                           nums[i],
                           nums[left],
                           nums[right]
                       });
                        // Skip duplicate left values
                        while (left < right && nums[left] == nums[left + 1])
                            left++;

                        // Skip duplicate right values
                        while (left < right && nums[right] == nums[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                }
            }
            return lst;
        }

    }
}
