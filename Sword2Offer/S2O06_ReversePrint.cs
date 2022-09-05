using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    public class S2O06_ReversePrint : Singleton<S2O06_ReversePrint>
    {
        public void invoke() {
            LinkList<int> linkList = new LinkList<int>();
            linkList.Append(1);
            linkList.Append(3);
            linkList.Append(2);
            ReversePrint(linkList.Head);
        }

        public int[] ReversePrint(ListNode<int> head)
        {
            int[] res;
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }
            res = new int[stack.Count];
            int index = 0;
            while (stack.Count!=0)
            {
                res[index++] = stack.Pop();
            }
            return res;
        }
    }
}
