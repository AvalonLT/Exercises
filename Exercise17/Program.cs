//Given an nxn grid of consecutive numbers, return the grid's Diamond Sum. 
//The diamond sum is defined as the sum of the numbers making up the diagonals between adjacent sides.

//DiamondSum(1) ➞ 1
//[1]

//DiamondSum(3) ➞ 20
//[
//  [1, 2, 3],
//  [4, 5, 6],
//  [7, 8, 9]
//]
// The numbers behind the underscores make up the Diamond Sum.
// 2 + 4 + 6 + 8 = 20

//DiamondSum(5) ➞ 104
//[
//  {1, 2, 3, 4, 5},
//  {6, 7, 8, 9, 10},
//  {11, 12, 13, 14, 15},
//  {16, 17, 18, 19, 20},
//  {21, 22, 23, 24, 25}
//]
// 3 + 7 + 9 + 11 + 15 + 17 + 19 + 23 = 104

using System;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[,]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };

            DiamondSum(grid);
        }

        public static int DiamondSum(int[,] grid)
        {
            var sum = 0;

            sum += grid[0, (int)Math.Sqrt(grid.Length) / 2];

            for (int i = 1; i < (int)Math.Sqrt(grid.Length) - 1; i++)
            {
                var j = 1;
                if (i < (int)Math.Sqrt(grid.Length / 2))
                {
                    sum += grid[i, (int)Math.Sqrt(grid.Length) / 2 - i];
                    sum += grid[i, (int)Math.Sqrt(grid.Length) / 2 + i];
                }
                else if (i > (int)Math.Sqrt(grid.Length) / 2)
                {
                    sum += grid[i, j];
                    sum += grid[i, (int)Math.Sqrt(grid.Length) - j - 1];
                    j++;
                }
            }

            sum += grid[(int)Math.Sqrt(grid.Length) - 1, (int)Math.Sqrt(grid.Length) / 2];

            return sum;
        }
    }
}
