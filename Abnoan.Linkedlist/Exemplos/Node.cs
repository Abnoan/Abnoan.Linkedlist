using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Linkedlist.Exemplos
{
public class Node
{
    public int Value;
    public Node Next;

    public Node(int value)
    {
        this.Value = value;
        this.Next = null;
    }
}

public class SinglyLinkedList
{
    public Node Head;

    public void InsertAtEnd(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void PrintAllNodes()
    {
        Node current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}

}