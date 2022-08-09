using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Backup.Easy
{
    public class _283MoveZeroesSolution : Singleton<_283MoveZeroesSolution>
    {
        public void MoveZeroes(int[] nums)
        {
            int left = 0, right = 0;

            while (right < nums.Length)
            {
                if (nums[right] != 0)
                {
                    int tmp = nums[right];
                    nums[right] = nums[left];
                    nums[left++] = tmp;
                }
                right++;
            }
        }
    }
}
