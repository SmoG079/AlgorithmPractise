namespace Algorithm.Backup.Easy
{
    public class _704BinarySearchSolution : Singleton<_704BinarySearchSolution>
    {
        public int BinarySearch(int[] nums,int target)
        {
            int left = 0,right = nums.Length-1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int num = nums[mid];
                if (num == target) return mid;
                else if (num > target) right = mid - 1;
                else left = mid + 1;
            }
            return -1;
        }
    }
}
