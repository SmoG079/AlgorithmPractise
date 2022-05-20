using Algorithm.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Backup.Medium
{
    public class _485FindMaxConsecutiveOnesSolution : Singleton<_485FindMaxConsecutiveOnesSolution>
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int left = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if ((i - left) > max) max = i - left;
                    left = i + 1;
                }
            }
            if (nums.Length - left > max) max = nums.Length - left;
            return max;
        }
    }
}
