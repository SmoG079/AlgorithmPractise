namespace Algorithm.Backup.Easy
{
    public class _278FirstBadVersionSolution : Singleton<_278FirstBadVersionSolution>
    {
        public int FirstBadVersion(int n)
        {
            int left = 0, right = n;
            int res = -1;
            while (right > left)
            {
                int mid = (right - left) / 2 + left;
                if (isBadVersion(mid)) right = mid;
                else left = mid + 1;
            }
            return left;
        }

        public bool isBadVersion(int version)
        {

            if (version >= 1) return true;
            else return false;
        }
    }
}
