using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        public Node head;

        /// <summary>
        /// Adding elements in the beginning of the LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void AddToBeginning(int data)
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
