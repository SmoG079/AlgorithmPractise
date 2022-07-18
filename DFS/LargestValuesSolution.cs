namespace Algorithm.DFS
{
    public class LargestValuesSolution : Singleton<LargestValuesSolution>
    {
        public IList<int> LargestValues(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null) return result;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                int count = queue.Count, levelMax = int.MinValue;
                for (int i = 0; i < count; i++)
                {
                    var cur = queue.Dequeue();
                    levelMax = Math.Max(levelMax, cur.val);
                    if (cur.left != null) { queue.Enqueue(cur.left); }
                    if (cur.right != null) { queue.Enqueue(cur.right); }
                }
                result.Add(levelMax);
            }
            return result;
        }

    }
}
