using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    public Node Head;

    public LinkedList()
    {
        Head = null;
    }

    public void Add(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = Head;
        Head = newNode;
    }

    public void BubbleSort()
    {
        if (Head == null || Head.Next == null)
        {
            // No need to sort an empty list or a list with only one element.
            return;
        }

        bool swapped;
        Node current;
        Node lastSorted = null;

        do
        {
            swapped = false;
            current = Head;

            while (current.Next != lastSorted)
            {
                if (current.Data > current.Next.Data)
                {
                    // Swap the data of current and next nodes.
                    int temp = current.Data;
                    current.Data = current.Next.Data;
                    current.Next.Data = temp;
                    swapped = true;
                }

                current = current.Next;
            }

            // Mark the last sorted node.
            lastSorted = current;
        } while (swapped);
    }

    public void Print()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        LinkedList linkedList = new LinkedList();

        linkedList.Add(64);
        linkedList.Add(34);
        linkedList.Add(25);
        linkedList.Add(12);
        linkedList.Add(22);
        linkedList.Add(11);
        linkedList.Add(90);

        Console.WriteLine("Original Linked List:");
        linkedList.Print();

        linkedList.BubbleSort();

        Console.WriteLine("\nSorted Linked List:");
        linkedList.Print();
    }
}
