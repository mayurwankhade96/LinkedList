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
            list.AddToEnd(56);
            list.AddToEnd(30);
            list.AddToEnd(70);
=======
            list.AddToBeginning(70);
            list.AddToBeginning(30);
            list.AddToBeginning(56);
>>>>>>> af5e68ac7e4f6d4a178304a7d254029bd8e7dfa6
            list.Display();
        }
    }
}
