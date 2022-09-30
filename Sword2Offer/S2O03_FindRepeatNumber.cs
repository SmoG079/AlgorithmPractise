using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    internal class S2O03_FindRepeatNumber :Singleton<S2O03_FindRepeatNumber>
    {
        public int FindRepeatNumber(int[] nums)
        {
            int res = Int16.MaxValue;
            Dictionary<int, int> numsRepeat = new Dictionary<int, int>();

            foreach (int i in nums) {
                if (numsRepeat.ContainsKey(i))
                {
                    return i;
                }
                else {
                    numsRepeat.Add(i, 1);   
                }
            }
            return res;
        }
    }
}
