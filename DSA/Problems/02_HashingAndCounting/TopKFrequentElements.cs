using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.HashingAndCounting
{
    internal class TopKFrequentElements
    {
        //arr = [1, 1, 1, 2, 2, 3]
        //k = 2
        public static int[] CountFrequent(int k, int[] arr)
        {
            Dictionary<int, int> dic =
                new Dictionary<int, int>();

            // Count frequency
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                }
                else
                {
                    dic[arr[i]] = 1;
                }
            }

            List<int> freq = new List<int>();

            int j = 0;

            while (j < k)
            {
                int max = int.MinValue;

                int value = 0;

                foreach (var item in dic)
                {
                    if (item.Value > max &&
                        !freq.Contains(item.Key))
                    {
                        max = item.Value;

                        value = item.Key;
                    }
                }

                freq.Add(value);

                j++;
            }

            return freq.ToArray();
        }

    }
}

