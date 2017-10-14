using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryDataStrucutres.LinkedList
{
    class Node<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>
    {
        T data;

        public Node<T> next;
        public Node<T> prev;
        public Node(T item)
        {
            this.data = item;
            this.next = null;
            this.prev = null;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }
    }
}
