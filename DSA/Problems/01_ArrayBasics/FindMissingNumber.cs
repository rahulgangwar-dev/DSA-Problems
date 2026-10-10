using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.ArrayBasics
{
    internal class FindMissingNumber
    {

        //int[] arr = { 2, 3, 4, 5 };

        //int ans = FindMissingNumber.MissingElement(2, arr);
        //Console.Write("Missing No. " + ans);
        public static int MissingElement(int startingPoint, int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int n = arr.Length + 1;
            int expectedSum = n * (n + 1) / 2;

            int ActSum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                ActSum = arr[i] + ActSum;
            }


            return expectedSum - ActSum;

        }


        //int[] arr = { 1, 4, 5, 7, 9 };

        //int ans = FindMissingNumber.MissingNumbersSum(arr);
        //Console.Write("Missing No. Sum " + ans);
        //public static int MissingNumbersSum(int[] nums)
        //{
        //    if (nums == null || nums.Length == 0) return 0;

        //    for(int i = 0; i < nums.Length; i++)
        //    {
        //        for(int j=i; j < nums.Length; j++)
        //        {
        //            if (nums[i] > nums[j])
        //            {
        //                int temp = nums[i];
        //                nums[i] = nums[j];
        //                nums[j] = temp;
        //            }
        //        }
        //    }

        //    int sum = 0;
        //    for(int i = 0; i < nums.Length - 1; i++)
        //    {
        //        int val = nums[i];
        //        while(val < nums[i + 1])
        //        {
        //            if(val+1 != nums[i + 1])
        //            {
        //                val = val + 1;
        //                sum = sum + val;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //    }

        //    return sum;
        //}

        //int[] arr = { 1, 2, 3, 4, 5 };

        //int[] ans = LeftRotateArraybyNPosition.RotateOnePositionLeft(arr);
        //for(int i=0;i<arr.Length;i++)
        //    Console.Write(" " + ans[i]);
        public static int[] RotateOnePositionLeft(int[] nums)
        {
            if (nums == null || nums.Length == 0) return new int[0];

            int FirstElement = nums[0];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }

            nums[nums.Length - 1] = FirstElement;

            return nums;
        }

    }
}

