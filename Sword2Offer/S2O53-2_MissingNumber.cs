using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    internal class S2O53_2_MissingNumber
    {
        public int MissingNumber(int[] nums)
        {
            int left = 0,right = nums.Length - 1;
            while (left <= right) {
                int mid = (left + right) / 2;
                if (nums[mid] != mid)
                {
                    right = mid;
                }
                else { 
                    left = mid + 1;
                }
            }
            return left == nums.Length-1 && nums[left] == left ? nums.Length : left;
        }
    }
}
