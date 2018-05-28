using System;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList linkedList = new MyLinkedList();
            linkedList.AddSorted(5);
            linkedList.AddSorted(11);
            linkedList.AddSorted(7);
            linkedList.AddSorted(13);
            linkedList.AddSorted(1);

            linkedList.Print();

            Console.ReadKey();
        }
    }
}
