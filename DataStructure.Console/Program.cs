using System.Collections.Generic;

namespace DataStructure.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = { 1, 3, 5, 7, 9 };

            var result = Searching.BinarySearhc(input, 3);

            System.Console.WriteLine(result);

            //var queue = new OwnQueue();

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);

            //queue.Display();

            //var item = queue.Dequeue();

            //System.Console.WriteLine(item);

            //queue.Display();


            //var stack = new OwnStack();

            //System.Console.WriteLine(stack.Count);

            //stack.Push(10);
            //stack.Push(50);
            //stack.Push(700);
            //stack.Push(101);
            //stack.Push(40);

            //System.Console.WriteLine(stack.Count);

            //stack.Pop();
            //stack.Pop();
            //System.Console.WriteLine(stack.Count);

            //var item = stack.Pop();
            //System.Console.WriteLine(item);
            //System.Console.WriteLine(stack.Count);



            //string str1 = "caad";
            //string str2 = "cdaa";

            //System.Console.WriteLine(Stringutil.isAnagram(str1,str2));

            //string input = "Hello thellllre!";
            //System.Console.WriteLine(Stringutil.FindMostRepeated(input));

            //string input = "ABCD";
            //string rotation = "CABC";

            //System.Console.WriteLine(Stringutil.IsRorationString(input, rotation)); 

            //string input = "I am developer";
            //System.Console.WriteLine(Stringutil.ReverseWords(input));

            //var input = new int[] { 1,3,4,5,15,25 };

            //var index=Searching.BinarySearhc(input, 25);
            //System.Console.WriteLine(index);

            //ShortingAlgorithms.SelectionShort(input);

            //foreach (var item in input)
            //{
            //    System.Console.Write(item + "\t");
            //}

            //var arr = new Array(2);
            //arr.insert(1);
            //arr.insert(2);
            //arr.insert(3);
            //arr.insert(4);
            //arr.reverse();
            //arr.Display();

            //System.Console.WriteLine(arr.max());

            //arr.Display();

            //var input = "a green apple";
            //System.Console.WriteLine(fistRepeatedChar(input));



        }

        public static char fistRepeatedChar(string input)
        {
            IDictionary<char, int> dictionary = new Dictionary<char, int>();

            var chars = input.ToCharArray();

            foreach (var ch in chars)
            {
                if (dictionary.TryGetValue(ch, out int count))
                {
                    dictionary[ch] = ++count;
                }
                else
                {
                    dictionary.Add(ch, 1);
                }
            }

            foreach (var ch in chars)
            {
                if (dictionary[ch] == 1)
                    return ch;
            }

            return char.MinValue;
        }
    }
}
