using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.HashingAndCounting
{
    internal class ContainsDuplicate
    {
        //Input: nums = [1,1,1,3,3,4,3,2,4,2]
        //Output: true
        public static bool ContainsDuplicates(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                    return true;

                dic[arr[i]] = i;
            }

            return false;
        }

    }
}

