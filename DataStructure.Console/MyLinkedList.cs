using System;
using System.Collections.Generic;

namespace DataStructure.Console
{

    public class MyLinkedList
    {
        private class Node
        {
            public Node(int value) => this.value = value;

            public int value;
            public Node next;
        }

        private Node first;
        private Node last;

        public void addLast(int value)
        {
            var node = new Node(value);

            if (isEmpty())
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }
        }

        public void addFirst(int value)
        {
            var node = new Node(value);

            if (isEmpty())
                first = last = node;
            else
            {
                node.next = first;
                first = node;
            }

        }

        public int indexOf(int value)
        {
            int count = 0;
            var tempNode = first;

            while(tempNode.next == null)
            {
                if (tempNode.value == value)
                    return count;

                count++;
                tempNode = tempNode.next;
            }

            return -1;
        }

        public void removeFist()
        {
            if (first == null)
                throw new Exception("Linked list is null");

            var second = first.next;
            first = null;
            first = second;

        }

        public void removeLast()
        {
            if (first == null)
                throw new Exception("Linked list is null");

            var temp = first;

            while(temp.next == last)
            {
                if(temp.next == last)
                {
                    var previous = temp;
                    last = previous;
                    last.next = null;
                }
            }


        }


        private bool isEmpty()
        {
            return first == null;
        }

        
    }
}
