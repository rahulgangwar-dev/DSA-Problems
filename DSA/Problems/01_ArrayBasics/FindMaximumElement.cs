using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.ArrayBasics
{
    internal class FindMaximumElement
    {

        //Find Maximum Element in Array
        //int[] arr = { 100, 2, 3, 4 };
        //int[] arr = { 2, 3, 6, 6, 5 };
        //int ans = FindMaximumElement.FindMax(arr);
        //Console.WriteLine("Maximum Element: "+ ans);
        //int ans1 = FindMaximumElement.FindSecondLargest(arr);
        //Console.WriteLine("Second Largest Element: "+ ans1);

        //maximam element from array
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

