using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.ArrayBasics
{
    internal class ReverseAnArray
    {
        //program.cs
        //int[] arr = { 2, 3, 4, 6, 5 };

        //arr = ReverseAnArray.Reverse(arr);
        //for(int i = 0; i<arr.Length; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}
        

        //reverse array [1,2,3,4,5,6]
        //public static int[] Reverse(int[] arr)
        //{
        //    int start = arr[0];
        //    int last = arr[arr.Length - 1];

        //    for (int i = 0; i < arr.Length / 2; i++)
        //    {
        //        int temp = arr[i];
        //        arr[i] = arr[arr.Length - 1 - i];
        //        arr[arr.Length - 1 - i] = temp;
        //    }

        //    return arr;
        //}

        public static int[] Reverse(int[] arr)
        {
            int left = 0;
            int right = arr.Length-1;

            while (left < right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }

            return arr;
        }

    }
}

