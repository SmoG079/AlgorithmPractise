namespace Algorithm.HashTable
{
    public class TwoSumSolution : Singleton<TwoSumSolution>
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
