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
            linkedList.Add(14);
            linkedList.Add(13);
            linkedList.Add(12);
            linkedList.Add(11);
            linkedList.Add(10);
            linkedList.Add(9);
            linkedList.Add(16);
            linkedList.Sort();
            linkedList.Print();
            Console.WriteLine("**************");
            linkedList.SortDescending();
            linkedList.Print();
        }
    }
}
