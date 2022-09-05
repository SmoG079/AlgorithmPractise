namespace Algorithm.Backup.Medium
{
    public class _2AddTwoNumbersSolution : Singleton<_2AddTwoNumbersSolution>
    {
        public ListNode<int> AddTwoNumbers(ListNode<int> l1, ListNode<int> l2)
        {
            int val = 0;
            ListNode<int> root = new ListNode<int>(0);
            ListNode<int> L = root;
            while (l1 != null || l2 != null || val != 0)
            {
                val = val + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                L.next = new ListNode<int>(val % 10);
                L = L.next; 
                val = val / 10;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }
            return root.next;
        }
    }
}
