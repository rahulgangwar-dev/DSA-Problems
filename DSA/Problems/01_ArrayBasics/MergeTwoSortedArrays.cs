using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.ArrayBasics
{
    internal class MergeTwoSortedArrays
    {
        //int[] arr = { 2,3,4 };

        public static int[] MergeArray(int[] arr1, int[] arr2)
        {
            int a = 0, b = 0;
            int len = arr1.Length + arr2.Length ;
            int i = 0;
            int[] arr = new int[len];

            while (a < arr1.Length && b < arr2.Length)
            {
                if (arr1[a] < arr2[b])
                {
                    arr[i] = arr1[a];
                    a++;
                }
                else
                {
                    arr[i] = arr2[b];
                    b++;
                }
                i++;
            }
            while (a < arr1.Length)
            {
                arr[i] = arr1[a];
                a++;
                i++;
            }

            while (b < arr2.Length)
            {
                arr[i] = arr2[b];
                b++;
                i++;
            }

            return arr;
        }
    }
}

