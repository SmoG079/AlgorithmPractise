namespace Algorithm.Backup.Medium
{
    public class _1004LongestOnesSolution : Singleton<_1004LongestOnesSolution>
    {
        public int LongestOnes(int[] nums, int k) 
        {
            int res = 0;
            int hasZero = 0;
            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    if ((i - left + 1) > res) res = i - left + 1;
                }
                else if (nums[i] == 0 && hasZero < k)
                {
                    if ((i - left + 1) > res)
                    {
                        res = i - left + 1;
                        hasZero++;
                    }
                }
                else
                {
                    if (nums[left] == 0)
                    {
                        left++;
                    }
                    else
                    {
                        do
                        {
                            left++;
                        } while (nums[left - 1] != 0);
                    }
                }
            }
            return res;
        }
    }
}
