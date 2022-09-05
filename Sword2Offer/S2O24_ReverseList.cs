using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    public class S2O24_ReverseList : Singleton<S2O24_ReverseList>
    {
        public void invoke() {
            LinkList<int> linkList = new LinkList<int>();
            linkList.Append(1);
            linkList.Append(2);
            linkList.Append(3);
            linkList.Append(4);
            linkList.Append(5);
            ReverseList2(linkList.Head);
        }
        public ListNode<int> ReverseList(ListNode<int> head)
        {

            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode<int> node = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return node;
        }

        public ListNode<int> ReverseList2(ListNode<int> head)
        {
            ListNode<int> node = head;
            ListNode<int> res = null;
            while (node!=null)
            {
                ListNode<int> next = node.next;
                node.next = res;
                res = node;
                node = next;
            }
            return res;
        }
    }
}
