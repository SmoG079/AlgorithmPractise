using Algorithm.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1_50
{
    public class _713NumSubarrayProductLessThanKSolution : Singleton<_713NumSubarrayProductLessThanKSolution>
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k == 0)
            {
                return 0;
            }
            int left = 0;
            int res = 0;
            int mul = 1;
            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] < k) res++;
                mul *= nums[left]*nums[right];
                for (int i = left + 1; i < nums.Length; i++)
                {
                    mul *= nums[i];
                    if (mul >= k) break;
                    res++;
                }
                mul = 1;
                left++;
            }
            return res;
        }

        public int NumSubarrayProductLessThanKBetterVersion(int[] nums, int k)
        {
            int n = nums.Length, ret = 0;
            int prod = 1, i = 0;
            for (int j = 0; j < n; j++)
            {
                prod *= nums[j];
                while (i <= j && prod >= k)
                {
                    prod /= nums[i];
                    i++;
                }
                ret += j - i + 1;
            }
            return ret;
        }
    }
}
