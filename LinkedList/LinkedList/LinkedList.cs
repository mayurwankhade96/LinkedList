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
        /// Adding elements in the beginning
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
=======
        /// Method to add data to the end of the LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void AddToEnd(int data)
>>>>>>> UC1-CreateLinkedList
        {
            Node node = new Node(data);

            if(this.head == null)
            {
                this.head = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = head;
                head = temp;
            }
        }

        /// <summary>
<<<<<<< HEAD
        /// Displaying the elements
=======
        /// Method to display data present in the LinkedList
>>>>>>> UC1-CreateLinkedList
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
