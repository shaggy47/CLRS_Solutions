using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementaryDataStrucutres.Queues
{
    class Queue
    {
        private int[] collection;
        private int initialCap;
        private int head;
        private int tail;
        private void IncreaseCapacity()
        {
            int[] temp = new int[initialCap * 2];
            Array.Copy(collection, temp, collection.Length);
        }

        public Queue()
        {
            initialCap = 10;
            collection = new int[initialCap];
            head = 0;
            tail = 0;
        }

        public int PeekHead()
        {
            return collection[head];
        }

        public int PeekTail()
        {
            return collection[tail-1];
        }

        public void EnQueue(int item)
        {
            if (tail == initialCap)
                IncreaseCapacity();

            collection[tail] = item;
            tail++;
        }

        public int DeQueue()
        {
            if (head < tail)
            {
                int item = collection[head];
                head++;
                return item;
            }
            else
                throw new Exception("Queue empty");
        }

        public bool IsEmpty()
        {
            if (head == tail)
                return true;
            else
                return false;
        }
    }
}
