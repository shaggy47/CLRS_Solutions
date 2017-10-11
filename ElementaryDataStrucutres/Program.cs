using ElementaryDataStrucutres.Queues;
using ElementaryDataStrucutres.Stacks;
using System;

namespace ElementaryDataStrucutres
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.EnQueue(10);
            queue.EnQueue(11);
            queue.EnQueue(12);
            queue.EnQueue(13);
            queue.EnQueue(14);
            queue.EnQueue(15);
            Console.WriteLine("Head = {0}, Tail = {1}", queue.PeekHead(), queue.PeekTail());
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.DeQueue());
            }
        }
    }
}
