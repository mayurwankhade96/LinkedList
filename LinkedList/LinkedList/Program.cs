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

            list.AddToBeginning(70);
            list.AddToBeginning(30);
            list.AddToBeginning(56);
            list.Display();
        }
    }
}
