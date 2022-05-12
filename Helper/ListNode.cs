using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Helper
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public ListNode InsertToTrail(ListNode node,int element)//尾插法
        {
            var r = node;
            ListNode s = new ListNode(element);
            r.next = s;
            r = s;
            r.next = null;
            return r;
        }

        public ListNode InsertToHead(ListNode node, int element)//头插法
        {
            var r = node;
            ListNode s = new ListNode(element);
            s.next = r;
            r=s;
            return r;
        }


        public ListNode CreatLinkedListByInsertToHead()
        {
            ListNode node = new ListNode();
            Console.WriteLine("Please input the node data of the list:");
            for (int i = 3; i > 0; i--)
            {
                int item = default(int);   //定义新结点数据域
                item = Convert.ToInt16(Console.ReadLine()); //从键盘输入的字符串转换成T。当不知道当前类型要转换成什么类型的情况下，用Convert.ChangeType(value，typeof(type))
                ListNode NewNode = new ListNode(item);
                NewNode.next = node;
                node = NewNode;
            }
            return node;

        }
    }
}
