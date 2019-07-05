using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            var customStack = new CustomStack(5);

            customStack.Push(5);
            customStack.Push(7);
            customStack.Push(9);

            Console.WriteLine(customStack.Pop());
            Console.WriteLine(customStack.Pop());
            Console.WriteLine(customStack.Pop());
            Console.WriteLine(customStack.Pop());


            Console.ReadKey();
        }
    }
}
