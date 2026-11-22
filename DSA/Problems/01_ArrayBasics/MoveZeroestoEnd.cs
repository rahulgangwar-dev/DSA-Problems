using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.ArrayBasics
{
    internal class MoveZeroestoEnd
    {

        //int[] arr = { 0, 1, 2, 5, 0, 1, 0, 3, 12 };
        //int[] arr1 = { 1, 4, 3, 2, 5, 7 };

        //int[] ans = MoveZeroestoEnd.ZeroestoEnd(arr);
        //for(int i=0;i<arr.Length;i++)
        //    Console.Write(" " + ans[i]);

        public static int[] ZeroestoEnd(int[] nums)
        {
            // 5, 0, 1, 0, 3, 12
            int currentIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[currentIndex] = nums[i];
                    currentIndex++;
                }
            }
            while (currentIndex < nums.Length)
            {
                nums[currentIndex] = 0;
                currentIndex++;
            }
            return nums;
        }

        //public static int[] ZeroestoEnd(int[] nums)
        //{
        //    // 5, 0, 1, 0, 3, 12
        //    int currentIndex = 0;
        //    bool movement = false;
        //    for(int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] == 0 && !movement)
        //        {
        //            currentIndex = i;
        //            movement = true;
        //        }
        //        else if (nums[i] != 0 && movement)
        //        {
        //            nums[currentIndex] = nums[i];
        //            nums[i] = 0;
        //            currentIndex++;
        //        }
        //    }
        //    return nums;
        //}



    }
}

