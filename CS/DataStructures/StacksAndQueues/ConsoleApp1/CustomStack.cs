using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class CustomStack
    {
        private int[] Stack;
        private int Top = -1;

        public CustomStack(int size) {
            Stack = new int[size];
        }

        private bool IsStackEmpty() {
            return Top == -1;
        }

        public void Push(int item) {
            Top += 1;
            Stack[Top] = item;
        }

        public int Pop()
        {
            if (IsStackEmpty())
            {
                return -1;
            }

            int item = Stack[Top];
            Top -= 1;
            return item;
        }
    }
}
