using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryDataStrucutres.Stacks
{
    class Stack<T>
    {
        private T[] collection;
        private int top;
        private int initialCap;

        private void IncreaseCap()
        {
            T[] temp = new T[initialCap * 2];
            Array.Copy(collection, temp, collection.Length);
            collection = temp;
        }

        public Stack()
        {
            initialCap = 10;
            collection = new T[initialCap];
            top = 0;
        }

        public void Push(T data)
        {
            if (top == initialCap)
                IncreaseCap();

            collection[top] = data;
            top++;
        }

        public T Pop()
        {
            T element = default(T);

            if (collection.Length > 0)
            {
                element = collection[--top];
            }

            return element;
        }

        public T Peek()
        {
            T element = default(T);

            if (collection.Length > 0)
            {
                element = collection[top - 1];
            }

            return element;
        }

        public bool IsEmpty()
        {
            if (top == 0)
                return true;
            else
                return false;
        }
    }
}
