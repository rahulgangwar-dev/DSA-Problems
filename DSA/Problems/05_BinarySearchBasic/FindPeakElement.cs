using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchBasic
{
    internal class FindPeakElement
    {
        //34. Find Peak Element

        //int[] nums = [1, 2, 1, 3, 5, 6, 4];

        //int E = FindPeakElement.PeakElement(nums);
        //Console.Write("Peak Element: " + E);
        public static int PeakElement(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                int mid = (start + end) / 2;
                if (arr[mid] < arr[mid + 1])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            return start;
        }

    }
}
