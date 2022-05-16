using Algorithm.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm._1_50
{
    public class _1TwoSumSolution : Singleton<_1TwoSumSolution>
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(target - nums[i]))
                {
                    return new int[] { result[target - nums[i]], i };
                }
                else
                {
                    result[nums[i]] = i;
                }
            }
            throw new Exception("failure");
        }
    }
}
