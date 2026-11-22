using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.ArrayBasics
{
    internal class LeftRotateArraybyNPosition
    {

        //int[] arr = { 1, 2, 3, 4, 5 };
        //int n = 4;

        //int[] ans = LeftRotateArraybyNPosition.RotateNPositionLeft(n, arr);
        //for (int i = 0; i<arr.Length; i++)
        //    Console.Write(" " + ans[i]);
        public static int[] RotateNPositionLeft(int k, int[] nums)
        {
            if (nums == null || nums.Length == 0) return new int[0];

            k = k % nums.Length;

            int index = 0;
            while (index < k)
            {
                int val = nums[0];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }
                nums[nums.Length - 1] = val;
                index++;
            }

            return nums;
        }

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

