using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.HashingAndCounting
{
    internal class ValidAnagram
    {

        //string s = "anagram";
        //string t = "nagaram";

        ////string s = "rat";
        ////string t = "ter";
        //bool check = ValidAnagram.Valid(s, t);
        //Console.Write("Check Anagram: "+check);

        public static bool Valid(string s, string t)
        {

            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> set1 = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
            {
                if (set1.ContainsKey(s[i])) set1[s[i]]++;
                else set1[s[i]] = 1;
                
            }

            for(int i = 0; i < t.Length; i++)
            {
                if (!set1.ContainsKey(t[i]))
                {
                    return false;
                }

                set1[t[i]]--;

                if (set1[t[i]] == 0)
                {
                    set1.Remove(t[i]);
                }
            }

            return set1.Count == 0;

        }

        public static bool Valid1(string s, string t)
        {

            if (s.Length != t.Length)
            {
                return false;
            }

            s = SortString(s);
            t = SortString(t);

            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i])
                {
                    return false;
                }
            }

            return true;

        }

        public static string SortString(string str)
        {
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length;i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        char temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return new string(arr);
        }
       
    }
}

