using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.HashingAndCounting
{
    internal class ValidPalindrome
    {
        //Given a string s, return true if it is a palindrome, or false otherwise.
        //Input: "A man, a plan, a canal: Panama"
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


