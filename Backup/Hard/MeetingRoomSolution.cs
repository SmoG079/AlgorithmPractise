using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Backup.Hard
{
    public class MeetingRoomSolution : Singleton<MeetingRoomSolution>
    {
        /**
        * This reference program is provided by @jiuzhang.com
        * Copyright is reserved. Please indicate the source for forwarding
        */
        /**
         * @param intervals: the intervals
         * @param rooms: the sum of rooms
         * @param ask: the ask
         * @return: true or false of each meeting
         */
        int[] sum = new int[50050];
        int[] vis = new int[50050];
        public bool[] meetingRoomIII(int[][] intervals, int rooms, int[][] ask)
        {
            // Write your code here.
            int length = ask.Length;
            bool[] ans = new bool[length];
            sum[0] = 0;
            int maxn = 0;
            int i;
            for (i = 0; i < intervals.Length; i++)
            {
                vis[intervals[i][0]]++;
                vis[intervals[i][1]]--;
                maxn = Math.Max(maxn, intervals[i][1]);
            }
            for (i = 0; i < ask.Length; i++)
            {
                maxn = Math.Max(maxn, ask[i][1]);
            }
            int tmp = 0;
            for (i = 1; i <= maxn; i++)
            {
                tmp += vis[i];
                if (tmp < rooms)
                {
                    sum[i] = 0;
                }
                else
                {
                    sum[i] = 1;
                }
            }
            for (i = 1; i <= maxn; i++) sum[i] += sum[i - 1];
            for (i = 0; i < ask.Length; i++)
            {
                if (sum[ask[i][0] - 1] == sum[ask[i][1] - 1])
                {
                    ans[i] = true;
                }
                else ans[i] = false;
            }
            return ans;
        }
    }

}
