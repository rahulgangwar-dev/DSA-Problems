using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Problems.GreedyAndDaily
{
    internal class BomberMan
    {

        //n = 5
        //    grid = [
        //            ".......",
        //            "...O...",
        //            "....O..",
        //            ".......",
        //            "OO.....",
        //            "OO....."
        //        ]

        public static List<string> bomberMan(int n, List<string> grid)
        {

            if (n == 1)
            {
                return grid;
            }
            if (n % 2 == 0)
            {
                return FillWithBombs(grid.Count, grid[0].Length);
            }

            var firstExplosion = Explose(grid);

            if (n % 4 == 3)
            {
                return firstExplosion;
            }
            var secondExplosion = Explose(firstExplosion);
            return secondExplosion;

        }

        public static List<string> FillWithBombs(int rows, int cols)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < rows; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < cols; j++)
                {
                    sb.Append('O');
                }
                result.Add(sb.ToString());
            }
            return result;

        }

        public static List<string> Explose(List<string> grid)
        {
            int rows = grid.Count;
            int cols = grid[0].Length;
            char[][] resultGrid = Enumerable.Range(0, rows).Select(_ => Enumerable.Repeat('O', cols).ToArray()).ToArray();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 'O')
                    {
                        resultGrid[i][j] = '.'; // Current cell
                        if (i > 0) resultGrid[i - 1][j] = '.'; // Up
                        if (i < rows - 1) resultGrid[i + 1][j] = '.'; // Down
                        if (j > 0) resultGrid[i][j - 1] = '.'; // Left
                        if (j < cols - 1) resultGrid[i][j + 1] = '.'; // Right

                    }
                }
            }

            return resultGrid.Select(row => new string(row)).ToList();
        }

        


    }

}
