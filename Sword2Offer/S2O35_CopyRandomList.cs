using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    public class S2O35_CopyRandomList : Singleton<S2O35_CopyRandomList>
    {
        public void invoke() {
            //CopyRandomList(new Node());
        }
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }
            for (Node node = head; node != null; node = node.next.next)
            {
                Node nodeNew = new Node(node.val);
                nodeNew.next = node.next;
                node.next = nodeNew;
            }
            for (Node node = head; node != null; node = node.next.next)
            {
                Node nodeNew = node.next;
                nodeNew.random = (node.random != null) ? node.random.next : null;
            }
            Node headNew = head.next;
            for (Node node = head; node != null; node = node.next)
            {
                Node nodeNew = node.next;
                node.next = node.next.next;
                nodeNew.next = (nodeNew.next != null) ? nodeNew.next.next : null;
            }
            return headNew;
        }
    }

    public class Node {
        public int val;
        public Node next;
        public Node random;
        public Node(int _val) {
            val = _val;
            next = null;
            random = null;
        }

    }
}
