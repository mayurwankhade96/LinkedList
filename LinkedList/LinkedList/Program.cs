using System;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Linked List Program!");

            // Creating a linkedlist using LinkedList class
            LinkedList list = new LinkedList();
<<<<<<< HEAD
            list.Add(70);
            list.Add(30);
            list.Add(56);
=======
            list.AddToEnd(56);
            list.AddToEnd(30);
            list.AddToEnd(70);
>>>>>>> UC1-CreateLinkedList
            list.Display();
        }
    }
}
