using Algorithm.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Backup.Medium
{
    public class _3LengthOfLongestSubstringSolution : Singleton<_3LengthOfLongestSubstringSolution>
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            int[] charTable = new int[256];

            int left = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (charTable[s[i]] > left)
                {
                    if (i - left > max) max = i - left;
                    left = charTable[s[i]];
                }
                charTable[s[i]] = i + 1;
            }
            if (s.Length - left > max) max = s.Length - left;
            return max;

        }
    }
}

