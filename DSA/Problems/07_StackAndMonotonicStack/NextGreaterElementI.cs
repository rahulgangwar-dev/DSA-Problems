using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.StackAndMonotonicStack
{
    partial class NextGreaterElementI
    {
        //Input: nums1 = [4, 1, 2], nums2 = [1, 3, 4, 2]
        //Output: [-1,3,-1]
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                int j = i + 1;
                dic[nums2[i]] = -1;
                while (j < nums2.Length)
                {
                    if (nums2[i] < nums2[j])
                    {
                        dic[nums2[i]] = nums2[j];
                        break;
                    }

                    j++;
                }
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                if (dic.ContainsKey(dic[nums1[i]]))
                    nums1[i] = dic[nums1[i]];
                else
                    nums1[i] = -1;
            }

            return nums1;
        }
    }
}
