using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.SlidingWindowTwoPointer
{
    internal class LongestSubstringWithoutRepeatingCharacters
    {
        //Input: s = "abcabcbb","1R1T7"
        //Output: 3,4
        //Explanation: "abc"

        public int LengthOfLongestSubstring(string s)
        {
            int left = 0;
            int maxLen = 0;
            Dictionary<char, int> dic = new Dictionary<char, int>();


            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]) && dic[s[i]] >= left)
                {
                    left = dic[s[i]] + 1;
                }
                dic[s[i]] = i;
                maxLen = Math.Max(maxLen, i - left + 1);

            }
            return maxLen;
        }
    }
}
