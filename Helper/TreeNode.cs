using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Helper
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public TreeNode CreateBinaryTree(LinkedList<int> inputList)
        {
            TreeNode node = null;
            if (inputList == null || inputList.Count <= 0)
            {
                return null;
            }
            int data = inputList.RemoveFirstEx();
            if (data != null)
            {
                node = new TreeNode(data);
                node.left = CreateBinaryTree(inputList);
                node.right = CreateBinaryTree(inputList);
            }
            return node;

        }
    }
}
