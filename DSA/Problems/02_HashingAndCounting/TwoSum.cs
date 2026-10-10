using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.HashingAndCounting
{
    internal class TwoSumProblem
    {
        //int[] arr = { 2,3,4 };

        //int[] arr = { 7, 1, 5, 3, 7, 4 };
        //int num = 4;

        //int[] ans = TwoSumProblem.TwoSum(num, arr);
        //Console.WriteLine(ans[0] + ", " + ans[1]);

        public static int[] TwoSum(int target, int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int needed = target - arr[i];

                if (dic.ContainsKey(needed))
                {
                    return new int[] { dic[needed], i };
                }

                if (!dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]] = i;
                }
            }
            return new int[] { -1, -1 };
        }

        public static int[] TwoSum1(int num, int[] arr)
        {
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == num)
                    {
                        index1 = i;index2 = j;
                        return new int[] { index1, index2 };
                    }
                }
            }

            return new int[] { index1, index2 };
        }

        
    }
}

