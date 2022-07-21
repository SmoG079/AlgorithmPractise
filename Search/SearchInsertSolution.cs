using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Search
{
    public class SearchInsertSolution : Singleton<SearchInsertSolution>
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (target == nums[mid]) return mid;
                if (target < nums[mid]) right = mid - 1;
                else left = mid + 1;
            }
            return left;
        }
    }
}
