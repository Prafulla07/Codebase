using System.Text;

namespace DataStructure.Console
{
    class OwnQueue
    {
        private int[] array = null;
        private int count = -1;
        private int size = 5;

        public OwnQueue()
        {
            array = new int[size];
        }

        public bool IsFull()
        {
            return count == size - 1;
        }

        public bool IsEmpty()
        {
            return count == -1;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
                throw new System.Exception("Queue is full");

            array[++count] = item;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new System.Exception("Queue is Empty.");

            return array[0];
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new System.Exception("Queue is Empty.");

            var first = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            count--;

            return first;

        }

        public void Display()
        {
            var output = new StringBuilder();

            for (int i = 0; i < count + 1; i++)
            {
                output.Append(array[i] + ", ");
            }

            System.Console.WriteLine(output.Remove(output.Length - 2, 1));
        }
    }
}
