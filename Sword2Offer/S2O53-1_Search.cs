using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    internal class S2O53_1_Search : Singleton<S2O53_1_Search>
    {
        public int Search(int[] nums, int target)
        {
            int leftIdx = BinarySearch(nums, target, true);
            int rightIdx = BinarySearch(nums, target, false) - 1;
            if (leftIdx <= rightIdx && rightIdx < nums.Length && nums[leftIdx] == target && nums[rightIdx] == target)
            {
                return rightIdx - leftIdx + 1;
            }
            return 0;
        }

        public int BinarySearch(int[] nums, int target, bool lower)
        {
            int left = 0, right = nums.Length - 1, ans = nums.Length;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] > target || (lower && nums[mid] >= target))
                {
                    right = mid - 1;
                    ans = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return ans;
        }
    }
}
