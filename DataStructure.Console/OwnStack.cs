using System;

namespace DataStructure.Console
{
    public class OwnStack
    {
        private int count = -1;
        private int[] array = null;
        private int size = 5;

        public OwnStack()
        {
            array = new int[size];
        }

        public int Count
        {
            get
            {
                if (count == -1)
                    return count + 1;

                return count + 1;
            }
        }

        public void Clear()
        {
            count = -1;
        }

        public int Peek()
        {
            if (count == -1)
                throw new Exception("Stack is Empty");

            return array[count];
        }

        public void Push(int value)
        {
            if (count == size - 1)
                throw new Exception("Array is full");

            array[++count] = value;
        }

        public int Pop()
        {
            if (count == -1)
                throw new Exception("Array is empty");

            return array[count--];

        }
    }
}
