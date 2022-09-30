using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    internal class S2O04_FindNumberIn2DArray : Singleton<S2O04_FindNumberIn2DArray>
    {
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            bool found = false;
            if (matrix == null || target == 0)
            {
                return found;
            }
            int m = matrix.Length,n = matrix[0].Length;
            int row = 0, col = n + 1;
            while (row < m && col >= 0)
            {
                if (matrix[row][col] > target)
                {
                    col--;
                }
                else if (matrix[row][col] < target)
                {
                    row++;
                }
                else
                {
                    found = true;
                }
            }
            return found;
        }
    }
}
