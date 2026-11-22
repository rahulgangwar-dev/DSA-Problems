using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.ArrayBasics
{
    internal class FindMaximumElement
    {
        public static int FindMax(int[] arr)
        {
            int maxElement = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement) maxElement = arr[i];
            }

            return maxElement;
        }

        //second largest element in array
        //int[] arr = { 2, 3, 6, 6, 5 };
        public static int FindSecondLargest(int[] arr)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i]>second && arr[i] < first)
                {
                    second = arr[i];
                }
            }
            return second;
        }


    }
}

