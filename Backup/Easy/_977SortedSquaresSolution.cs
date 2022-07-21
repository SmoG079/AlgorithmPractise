using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Backup.Easy
{
    public class _977SortedSquaresSolution : Singleton<_977SortedSquaresSolution>
    {
        public int[] SortedSquares(int[] nums) {
            int length = nums.Length;
            int[] result = new int[length];
            int left = 0, right = length - 1;
            int numleft, numright;
            while (left <= right)
            {
                numleft = nums[left] * nums[left];
                numright = nums[right] * nums[right];
                if (numleft >= numright)
                {
                    result[length - 1] = numleft;
                    length--;
                    left++;
                }
                else
                {
                    result[length - 1] = numright;
                    length--;
                    right--;
                }
            }
            return result;
        }
    }
}
