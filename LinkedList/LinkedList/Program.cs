using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Linked List Program!");

            // Creating a linkedlist using LinkedList class
            LinkedList list = new LinkedList();

            list.Add(56);
            list.Add(30);            
            list.Add(70);
            list.InsertAtParticularPosition(3, 40);
            list.Display();
        }
    }
}
