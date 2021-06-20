using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        public Node head;

        /// <summary>
<<<<<<< HEAD
        /// Adding elements at the end of the LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void AddToEnd(int data)
=======
        /// Adding elements in the beginning of the LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void AddToBeginning(int data)
>>>>>>> af5e68ac7e4f6d4a178304a7d254029bd8e7dfa6
        {
            Node node = new Node(data);

            if(this.head == null)
            {
                this.head = new Node(data);
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        /// <summary>
        /// Method to display data present in the LinkedList
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked List is empty!");
            }
            while(temp!= null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
