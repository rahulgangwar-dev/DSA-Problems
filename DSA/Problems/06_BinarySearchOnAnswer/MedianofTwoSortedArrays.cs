using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchOnAnswer
{
    internal class MedianofTwoSortedArrays
    {

        public static double Median(int[] arr1, int[] arr2)
        {
            int count = arr1.Length + arr2.Length;
            int count1 = 0;int count2 = 0;
            int[] arr = new int[arr1.Length + arr2.Length];
            int i = 0;
            while(count1 < arr1.Length && count2 < arr2.Length)
            {
                if (arr1[count1] < arr2[count2])
                {
                    arr[i] = arr1[count1];
                    count1++;
                }
                else
                {
                    arr[i] = arr2[count2];
                    count2++;
                }
                i++;
            }

            while (count1 < arr1.Length)
            {
                arr[i] = arr1[count1];
                count1++;
                i++;

            }

            while(count2 < arr2.Length)
            {
                arr[i] = arr2[count2];
                count2++;
                i++;
            }

            if(arr.Length %2 == 0)
            {

                int mid = arr.Length / 2;
                return (double)(arr[mid - 1] + arr[mid])/2;
            }
            else
            {
                int mid = arr.Length / 2;
                return (double)arr[mid];
            }
        }

    }
}
