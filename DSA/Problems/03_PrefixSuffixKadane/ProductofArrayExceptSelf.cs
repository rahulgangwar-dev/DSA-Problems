using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.PrefixSuffixKadane
{
    internal class ProductofArrayExceptSelf
    {
        //[1, 2, 3, 4]
        public static int[] ProductofArray(int[] arr)
        {
            int n = arr.Length;

            int[] prefix = new int[n];
            int[] suffix = new int[n];
            int[] answer = new int[n];

            // Prefix array
            prefix[0] = 1;
            for (int i = 1; i < n; i++)
            {
                prefix[i] = prefix[i - 1] * arr[i - 1];
            }

            // Suffix array
            suffix[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                suffix[i] = suffix[i + 1] * arr[i + 1];
            }

            // Final answer
            for (int i = 0; i < n; i++)
            {
                answer[i] = prefix[i] * suffix[i];
            }

            return answer;
        }



        //brote force algorithm
        public static int[] ProductofArray1(int[] arr)
        {
            int[] answer = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                int sum = 1;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                        sum = sum * arr[j];
                }
                answer[i] = sum;
            }
            return answer;
        }

        
    }
}

