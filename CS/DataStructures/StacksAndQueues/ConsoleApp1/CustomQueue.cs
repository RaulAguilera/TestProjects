using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class CustomQueue
    {
        public int[] Q;
        public int Head = 0;
        public int Tail = 0;

        public CustomQueue(int size)
        {
            Q = new int[size];
        }

        public void Enqueue(int item)
        {
            Q[Tail] = item;
            if (Tail == Q.Length - 1)
                Tail = 0;
            else
                Tail++;
        }

        public int Dequeue()
        {
            int item = Q[Head];

            if (Head == Q.Length - 1)
                Head = 0;
            else
                Head++;

            return item;
        }

    }
}
