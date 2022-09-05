namespace Algorithm.Helper
{
    public class ListNode<T>
    {

        public T val { set; get; }          //数据域,当前结点数据
        public ListNode<T> next { set; get; }    //位置域,下一个结点地址

        public ListNode(T item)
        {
            this.val = item;
            this.next = null;
        }

        public ListNode()
        {
            this.val = default(T);
            this.next = null;
        }
    }

    public class LinkList<T>
    {
        public ListNode<T> Head { set; get; } //单链表头

        //构造
        public LinkList()
        {
            Head = null;
        }

        /// <summary>
        /// 增加新元素到单链表末尾
        /// </summary>
        public void Append(T item)
        {
            ListNode<T> newNode = new ListNode<T>(item);
            ListNode<T> p = new ListNode<T>();
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            p = Head;
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = newNode;
        }

        public void Delete(int i)
        {
            ListNode<T> temp = new ListNode<T>();
            if (i == 1)   //删除头
            {
                temp = Head;
                Head = Head.next;
                return;
            }
            ListNode<T> p = new ListNode<T>();
            p = Head;
            int j = 1;
            while (p.next != null && j < i)
            {
                temp = p;
                p = p.next;
                j++;
            }
            if (j == i)
            {
                temp.next = p.next;
            }
        }
    }
}
