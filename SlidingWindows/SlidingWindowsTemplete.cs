using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.SlidingWindows
{
    /// <summary>
    /// 基于LongestOnes的SlidingWindows模板
    /// </summary>
    public class SlidingWindowsTemplete
    {
        public int SlidingWindows(int[] A, int K)
        {
            int left = 0, right = 0, zeroCounter = 0;
            while (right < A.Length)
            {
                if (A[right] == 0) zeroCounter++;
                if (zeroCounter > K)
                {
                    left++;
                    if (A[left - 1] == 0) zeroCounter--;
                }
                right++;
            }
            return right - left;
        }

    }
}
