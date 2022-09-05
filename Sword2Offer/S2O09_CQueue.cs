using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    public class S2O09_CQueue : Singleton<S2O09_CQueue>
    {
        public void invoke() {

            CQueue obj = new CQueue();
            obj.AppendTail(1);
            obj.AppendTail(8);
            obj.AppendTail(20);
            obj.AppendTail(1);
            obj.AppendTail(11);
            obj.AppendTail(2);
            int param_2 = obj.DeleteHead();
            int param_3 = obj.DeleteHead();
            int param_4 = obj.DeleteHead();
            int param_5 = obj.DeleteHead();
        }
    }

    public class CQueue {
        Stack<int> Instack;
        Stack<int> Outstack;
        public CQueue()
        {
            Instack = new Stack<int>();
            Outstack = new Stack<int>();
        }
        public void AppendTail(int value)
        {
            Instack.Push(value);
        }
        public int DeleteHead()
        {
            if (Instack.Count == 0 && Outstack.Count==0)
            {
                return -1;
            }
            else if (Outstack.Count==0)
            {
                for (int i = 0; i < Instack.Count; )
                {
                    Outstack.Push(Instack.Pop());
                }
            }
            return Outstack.Pop();
        }
    }


 /**
 * Your CQueue object will be instantiated and called as such:
 * CQueue obj = new CQueue();
 * obj.AppendTail(value);
 * int param_2 = obj.DeleteHead();
 */
}
