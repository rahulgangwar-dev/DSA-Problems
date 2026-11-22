using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.SlidingWindowTwoPointer
{
    internal class ThreeSum
    {
        //Input: nums = [-1,0,1,2,-1,-4]
        //after sorting =  [-1,-1,0,1,2,4]
        //Output: [[-1,-1,2],[-1,0,1]]
        public static List<List<int>> Sum3New(int[] arr)
        {
            List<List<int>> lists = new List<List<int>>();
            //Array.Sort(arr);

            for (int i = 1; i < arr.Length-1; i++)
            {
                int start = i + 1;
                int end = arr.Length-1;
                while(start<end)
                {
                    List<int> ints = new List<int>();
                    int sum = arr[i] + arr[start] + arr[end];
                    if(sum == 0)
                    {
                        ints.Add(arr[start]);
                        ints.Add(arr[i]);
                        ints.Add(arr[end]);
                        lists.Add(ints);
                        start++;
                        end--;
                    }
                    else if (sum < 0)
                    {
                        start++;
                    }
                    else
                    {
                        end--;
                    }
                }
            }

            return lists;
        }
        public static List<List<int>> Sum3(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<List<int>> lists = new List<List<int>>();

            for (int i = 0; i < arr.Length-1; i++)
            {
                for(int j = i+1; j < arr.Length-1; j++)
                {
                    for(int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            List<int> pair = new List<int>();
                            pair.Add(arr[i]);
                            pair.Add(arr[j]);
                            pair.Add(arr[k]);

                            lists.Add(pair);
                        }
                    }
                }
            }

            return lists;
        }

    }
}

