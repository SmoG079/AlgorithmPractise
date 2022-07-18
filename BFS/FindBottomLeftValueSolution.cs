namespace Algorithm.BFS
{
    public class FindBottomLeftValueSolution : Singleton<FindBottomLeftValueSolution>
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            int result = root.val;
            if (root.left == null && root.right == null) return result;
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                result = q.Peek().val;
                TreeNode node = q.Dequeue();
                if (node.right != null) q.Enqueue(node.right);
                if (node.left != null) q.Enqueue(node.left);
            }
            return result;
        }

    }
}
