using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryDataStrucutres.LinkedList
{
    class LinkedList<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>
    {
        private Node<T> head;
        private ListType type;

        private Node<T> AddRecursive(Node<T> node, T data)
        {
            if (node == null)
            {
                node = new Node<T>(data)
                {
                    next = null
                };
            }
            else
            {
                Node<T> prev = AddRecursive(node.next, data); ;
                node.next = prev;

                if (type == ListType.Doubly)
                {
                    prev.prev = node;
                }
            }

            return node;
        }

        public LinkedList()
        {
            head = null;
            this.type = ListType.Singly;
        }

        public LinkedList(ListType listType)
        {
            head = null;
            this.type = listType;
        }

        public void Add(T data)
        {
            head = AddRecursive(head, data);
        }

        public void Insert(T data, int position)
        {
            int count = 0;
            Node<T> temp = head;
            Node<T> prev = null;
            while (count < position && temp != null)
            {
                count++;
                prev = temp;
                temp = temp.next;
            }

            if (prev != null)
            {
                prev.next = new Node<T>(data);
                prev.next.next = temp;
            }

            if (prev == null)
            {
                prev = new Node<T>(data);
                prev.next = temp;
                head = prev;
            }
        }

        public void Delete(int position)
        {
            int count = 0;
            Node<T> temp = head;
            Node<T> prev = null;
            while (count < position && temp != null)
            {
                count++;
                prev = temp;
                temp = temp.next;
            }

            if (temp != null && prev != null)
            {
                Node<T> deleted = temp;
                prev.next = temp.next;
            }
            else if (temp != null && prev == null)
            {
                temp = temp.next;
                head = temp;
            }
        }

        public void Print()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.ToString());
                temp = temp.next;
            }
        }

    }
}
