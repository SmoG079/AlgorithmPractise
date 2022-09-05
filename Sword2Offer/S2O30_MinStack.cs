using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sword2Offer
{
    public class S2O30_MinStack : Singleton<S2O30_MinStack>
    {
        public void invoke() {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            int min = minStack.Min(); 
            minStack.Pop();
            min = minStack.Top(); 
            min = minStack.Min(); 
        }
    }

    public class MinStack
    {
        Stack<int> stack;
        Stack<int> min;
        /** initialize your data structure here. */
        public MinStack()
        {
            stack = new Stack<int>();
            min = new Stack<int>();
            min.Push(Int32.MaxValue);
        }

        public void Push(int x)
        {
            stack.Push(x);
            min.Push(Math.Min(min.Peek(),x));
        }

        public void Pop()
        {
            stack.Pop();
            min.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int Min()
        {
            return min.Peek();
        }
    }

}
