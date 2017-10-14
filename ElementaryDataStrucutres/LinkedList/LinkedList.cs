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
        private int count;

        private Node<T> Head
        {
            get
            {
                return this.head;
            }

            set
            {
                this.head = value;
            }
        }

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
            count = 0;
        }

        public LinkedList(ListType listType)
        {
            head = null;
            this.type = listType;
            count = 0;
        }

        public void Add(T data)
        {
            head = AddRecursive(head, data);
            ++count;
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
            Node<T> current = head;
            Node<T> next = head.next;
            Node<T> prev = null;
            while (count < position && current != null)
            {
                prev = current;
                current = current.next;
                next = next.next;
                count++;
            }

            if (count == 0)
            {
                current = head;
                head = head.next;
                this.count--;
            }
            else
            {
                prev.next = current.next;
                this.count--;
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

        public bool IsEmpty()
        {
            if (count == 0)
                return true;
            else
                return false;
        }

        
        private void Copy(LinkedList<T> souce)
        {
            this.Head = souce.Head; 
        }

        private Node<T> Min()
        {
            Node<T> temp = head;
            Node<T> minNode = temp;
            int position = 0;
            int minPos = 0;
            while (temp != null)
            {
                if (temp < minNode)
                {
                    minNode = temp;
                    minPos = position;
                }

                temp = temp.next;
                position++;
            }

            //remove min node from the list;
            Delete(minPos);
            minNode.next = null;
            return minNode;
        }

        public void Sort()
        {
            Node<T> temp = head;
            Node<T> sorted = null;
            LinkedList<T> newList = new LinkedList<T>();
            while (!IsEmpty())
            {
                sorted = Min();
                newList.Add(sorted.Data);
            }

            Copy(newList);
        }

        public void SortDescending()
        {

        }
    }
}
