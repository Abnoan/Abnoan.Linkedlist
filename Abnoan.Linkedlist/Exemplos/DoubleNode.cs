using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Linkedlist.Exemplos
{
    public class DoubleNode
    {
        public int Value;
        public DoubleNode Next;
        public DoubleNode Prev;

        public DoubleNode(int value)
        {
            this.Value = value;
            this.Next = null;
            this.Prev = null;
        }
    }

    public class DoublyLinkedList
    {
        public DoubleNode Head;

        public void InsertAtEnd(int value)
        {
            DoubleNode newNode = new DoubleNode(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                DoubleNode current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                newNode.Prev = current;
            }
        }

        public void PrintAllNodes()
        {
            DoubleNode current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}