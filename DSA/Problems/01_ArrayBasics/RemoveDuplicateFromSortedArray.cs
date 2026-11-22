using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.ArrayBasics
{
    internal class RemoveDuplicateFromSortedArray
    {

        //int[] arr = { 1, 2, 2, 3, 3, 3, 4, 5, 6, 6, 6, 7, 8 };
        //int[] arr1 = { 1, 4, 3, 2, 5, 7 };

        //bool check = RemoveDuplicateFromSortedArray.checkSorted(arr1);
        //Console.WriteLine("Sorted: "+check);

        //int ans = RemoveDuplicateFromSortedArray.RevomeDuplicates(arr);
        //Console.WriteLine(ans);

        //1,2,2,3,3,3,4,5,6,6,6,7,8

        public static bool checkSorted(int[] nums)
        {
            for(int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i]> nums[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static int RevomeDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int currentIndex = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[currentIndex-1])
                {
                    nums[currentIndex] = nums[i];
                    currentIndex++;
                }
            }

            return currentIndex;
        }


    }
}

