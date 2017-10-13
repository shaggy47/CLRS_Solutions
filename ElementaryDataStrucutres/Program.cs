using ElementaryDataStrucutres.Queues;
using ElementaryDataStrucutres.Stacks;
using System;

namespace ElementaryDataStrucutres
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList.LinkedList<int> linkedList = new LinkedList.LinkedList<int>();
            linkedList.Add(10);
            linkedList.Add(11);
            linkedList.Add(12);
            linkedList.Add(13);
            linkedList.Add(14);
            linkedList.Insert(0, 0);
            linkedList.Delete(3);
            linkedList.Print();
        }
    }
}
