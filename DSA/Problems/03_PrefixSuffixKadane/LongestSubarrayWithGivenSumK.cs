using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.PrefixSuffixKadane
{
    internal class LongestSubarrayWithGivenSumK
    {
        //arr = [1, 2, 3, 1, 1, 1, 1]
        //K = 6

        //int[] arr = { 1, 2, 3, 1, 1, 1 };
        //int k = 6;

        //int[] ans1 = LongestSubarrayWithGivenSumK.SubarrayWithGivenSumK1(k, arr);
        //Console.Write("Subarray With Given Sum K: ");
        //for (int i = 0; i<ans1.Length; i++)
        //    Console.Write(" " + ans1[i]);

        //int[] ans = LongestSubarrayWithGivenSumK.SubarrayWithGivenSumK(k, arr);
        //Console.Write("Subarray With Given Sum K: ");
        //for (int i = 0; i < ans.Length; i++)
        //    Console.Write(" " + ans[i]);


        public static int[] SubarrayWithGivenSumK1(int k, int[] arr)
        {

            int sum = 0;
            int maxLen = 0;

            int start = -1;
            int end = -1;

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if(sum == k)
                {
                    maxLen = i + 1;
                    start = 0;
                    end = i;
                }

                int needed = sum - k;
                if (dic.ContainsKey(needed))
                {
                    int len = i - dic[needed];
                    if (len > maxLen)
                    {
                        maxLen = len;
                        start = dic[needed] + 1;
                        end = i;
                    }
                }

                if (!dic.ContainsKey(sum))
                {
                    dic[sum] = i;
                }
            }

            if (start == -1)
            {
                return new int[0];
            }

            int[] ans = new int[end - start + 1];

            int index = 0;

            for (int i = start; i <= end; i++)
            {
                ans[index] = arr[i];
                index++;
            }

            return ans;
        }
        public static int[] SubarrayWithGivenSumK(int k,int[] arr)
        {
            int max = 0;
            int startIndex = 0, endingIndex = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                int count = 0;
                for(int j = i; j < arr.Length; j++)
                {
                    count++;
                    sum = sum + arr[j];
                    if(sum == k)
                    {
                        if (count > max)
                        {
                            max = count;
                            startIndex = i;
                            endingIndex = j;
                        }
                        break;
                    }
                }
            }

            int[] ans = new int[endingIndex-startIndex+1];
            int a = 0;
            for(int i = startIndex; i <= endingIndex && a<ans.Length; i++)
            {
                ans[a] = arr[i];
                a++;
            }

            return ans;
        }
    }
}

