using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.HashingAndCounting
{
    internal class LongestConsecutiveSequence
    {
        //Input: nums = [1,1,1,3,3,4,3,2,4,2]
        //Output: true

        public static int ConsecutiveSequence(int[] arr)
        {
            HashSet<int> h = new HashSet<int>();

            foreach (int num in arr)
            {
                h.Add(num);
            }

            int maxCount = 0;

            foreach (int num in h)
            {
                // start of sequence
                if (!h.Contains(num - 1))
                {
                    int currentNum = num;
                    int count = 1;

                    while (h.Contains(currentNum + 1))
                    {
                        currentNum++;
                        count++;
                    }

                    maxCount = Math.Max(maxCount, count);
                }
            }

            return maxCount;
        }

        //public static int ConsecutiveSequence(int[] arr)
        //{
        //    if (arr.Length == 0)
        //        return 0;

        //    Array.Sort(arr);

        //    int maxCount = 1;
        //    int count = 1;

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        // skip duplicates
        //        if (arr[i] == arr[i - 1])
        //        {
        //            continue;
        //        }

        //        // consecutive
        //        if (arr[i] == arr[i - 1] + 1)
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            count = 1;
        //        }

        //        maxCount = Math.Max(maxCount, count);
        //    }

        //    return maxCount;
        //}

    }
}

