/*
 * Title:LinkedListLab
 * Author:Elliot Jost
 * Date: 2025-03-27
 */

namespace LinkedListSpace
{
    public class LinkedList
    {
        private class Node
        {
            public string Value;
            public Node Next;
            public Node(string value)
            {
                Value = value;
                Next = null;
            }
        }

        private int count;
        private Node head;

        public int Count => count;
        public string Head => head?.Value;

        public void AddFirst(string value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
            count += 1;
        }

        public void AddLast(string value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;

            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;

            }
            count += 1;
        }
        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.Next;
                count -= 1;
            }
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                return;
            }
            else if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            count -= 1;
        }

        public string GetValue(int index)
        {
            if ((index < 0) || (index >= count))
            {
                throw new IndexOutOfRangeException("Index Out of Bounds");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            
            list.AddFirst("First");
            list.AddLast("Middle");
            list.AddLast("Last");
            list.RemoveLast();
            list.RemoveFirst();

            Console.WriteLine(list.GetValue(0));

        }
    }
}