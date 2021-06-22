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
            list.DeleteNode(40);
            list.Display();
            Console.WriteLine("\n" + "Linked List Size : " + list.Size());

            LinkedList listOne = new LinkedList();
            listOne.Sort(56);
            listOne.Sort(30);
            listOne.Sort(40);
            listOne.Sort(70);
            listOne.Display();
        }
    }
}
