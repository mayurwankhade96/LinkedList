﻿using System;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Linked List Program!");

            // Creating a linkedlist using LinkedList class
            LinkedList list = new LinkedList();

            list.AddToEnd(56);
            list.AddToEnd(70);
            list.InsertAtParticularPosition(2, 30);
            list.Display();
        }
    }
}
