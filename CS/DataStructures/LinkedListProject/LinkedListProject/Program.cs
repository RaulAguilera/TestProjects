using System;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList linkedList = new MyLinkedList();
            linkedList.AddToEnd(1);
            linkedList.AddToEnd(2);
            linkedList.AddToEnd(3);

            linkedList.Print();

            Console.ReadKey();
        }
    }

    public class Node {
        public int data;
        public Node next;

        public Node(int i) {
            data = i;
            next = null;
        }

        public void Print() {
            Console.Write("|" + data + "|->");

            if (next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(int data) {
            if (next == null)
            {
                next = new Node(data);
            }
            else {
                next.AddToEnd(data);
            }
        }
    }

    public class MyLinkedList {

        Node headNode;

        public MyLinkedList() {
            headNode = null;
        }

        public void AddToEnd(int data) {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else {
                headNode.AddToEnd(data);
            }
        }

        public void Print() {
            if (headNode != null) {
                headNode.Print();
            }
        }

    }
}
