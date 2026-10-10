using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.HashingAndCounting
{
    internal class GroupAnagram
    {

        //string[] s = ["eat", "tea", "tan", "ate", "nat", "bat"];

        ////string s = "rat";
        ////string t = "ter";
        //List<List<string>> str = GroupAnagram.GroupAnagrams(s);
        //foreach(var p in str)
        //{
        //    foreach(var x in p)
        //    {
        //        Console.Write(x+" ");
        //    }
        //    Console.WriteLine("");
        //}

        public static List<List<string>> GroupAnagrams(string[] arr)
        {
            Dictionary<string, List<string>> dic =
                new Dictionary<string, List<string>>();

            for (int i = 0; i < arr.Length; i++)
            {
                // Sort current string
                string sorted = SortString(arr[i]);

                // Create list if key doesn't exist
                if (!dic.ContainsKey(sorted))
                {
                    dic[sorted] = new List<string>();
                }

                // Add original string into group
                dic[sorted].Add(arr[i]);
            }

            // Convert dictionary values into final answer
            List<List<string>> ans = new List<List<string>>();

            foreach (var item in dic)
            {
                ans.Add(item.Value);
            }

            return ans;
        }

        public static string SortString(string str)
        {
            char[] arr = str.ToCharArray();

            // Bubble Sort
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        char temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return new string(arr);
        }

    }
}

