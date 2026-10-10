using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.BinarySearchBasic
{
    internal class Searcha2DMatrix
    {

        //int[][] arr = [
        //               [1,3,5,7],
        //                 [10,11,16,20],
        //                 [23,30,34,60]
        //              ];
        //int target = 34;

        //bool ans = Searcha2DMatrix.SearchMatrix(arr, target);
        //Console.Write("Found: " + ans);

        public static bool SearchMatrix(int[][] matrix,int target)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int start = 0;
            int end = (rows * cols) - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                int row = mid / cols;
                int col = mid % cols;

                int value = matrix[row][col];
                if(value == target)
                {
                    return true;
                }
                else if (value < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return false;
        }
    }
}
