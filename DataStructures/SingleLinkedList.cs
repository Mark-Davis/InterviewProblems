using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SingleLinkedList<T>
    {
        public class Node
        {
            public T data;
            public Node next;

            public Node(T value)
            {
                data = value;
                next = null;
            }
        }

        public Node head;

        // Insert data at beginning of list
        public Node Insert(T data)
        {
            Node node = new Node(data);

            node.next = head;
            head = node;

            return node;
        }

        // Add data to end of list
        public Node Add(T data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node curr = head;
                while (curr.next != null)
                {
                    curr = curr.next;
                }

                curr.next = node;
            }

            return node;
        }

        // Delete node from list
        public Node Delete(Node node)
        {
            if (head == null
             || node == null)
            {
                return null;
            }

            if (head == node)
            {
                head = node.next;
                return node;
            }

            Node curr = head;
            while (curr.next != null)
            {
                if (curr.next == node)
                {
                    curr.next = node.next;
                    return node;
                }
                curr = curr.next;
            }

            return null;
        }

        public Node Find(Node node)
        {
            Node curr = head;
            while (curr != null
                && curr != node)
            {
                curr = curr.next;
            }

            return curr;
        }

        public Node FindNthToLast(int n)
        {
            // Advance ahead pointer
            Node front = head;
            for (int i=0; i<n; i++)
            {
                if (front != null)
                {
                    front = front.next;
                }
                else
                {
                    return null;
                }
            }

            Node behind = head;
            while (front != null)
            {
                front = front.next;
                behind = behind.next;
            }

            return behind;
        }
    }
}
