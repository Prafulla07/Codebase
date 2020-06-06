using System.Collections.Generic;

namespace DataStructure.Console
{
    public class MyStack
    {
        private int[] stack;
        private int index=0;
        private int stackSize = 5;

        public MyStack()
        {
            stack = new int[stackSize];
        }

        public bool isEmpty()
        {
            return index == 0;
        }

        public void push(int item)
        {
            if(stackSize == index)
            {
                stackSize *= 2;
                var newStack = new int[stackSize];
                stack.CopyTo(newStack,0);
                stack = newStack;
            }

            stack[index++] = item;
        }


        public string reverseString(string input)
        {
            var stack = new Stack<char>();
            var reverse = string.Empty;

            foreach (var item in input.ToCharArray())
            {
                stack.Push(item);
            }
           

            while(stack.Count > 0)
            {
                reverse = reverse + stack.Pop();
            }

            return reverse;

        }
    }
}
