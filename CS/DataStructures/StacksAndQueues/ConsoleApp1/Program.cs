using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomQueue();


            Console.ReadKey();
        }

        static void TestCustomStack() {
            var customStack = new CustomStack(5);

            customStack.Push(5);
            customStack.Push(7);
            customStack.Push(9);

            Console.WriteLine(customStack.Pop());
            Console.WriteLine(customStack.Pop());
            Console.WriteLine(customStack.Pop());
            Console.WriteLine(customStack.Pop());
        }

        static void TestCustomQueue() {
            var customQueue = new CustomQueue(5);

            customQueue.Enqueue(1);
            customQueue.Enqueue(2);
            customQueue.Enqueue(3);

            Console.WriteLine(customQueue.Dequeue());
            Console.WriteLine(customQueue.Dequeue());

            customQueue.Enqueue(4);
            customQueue.Enqueue(5);
            customQueue.Enqueue(6);

            Console.WriteLine(customQueue.Dequeue());
            Console.WriteLine(customQueue.Dequeue());
            Console.WriteLine(customQueue.Dequeue());
            Console.WriteLine(customQueue.Dequeue());


        }
    }
}
