using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        public Node head;

        /// <summary>
        /// Adding elements at the end of the LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void AddToEnd(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = new Node(data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
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
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty!");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        /// <summary>
        /// Adding elements at particular position in LinkedList
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position!");

            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        /// <summary>
        /// Method to remove first node from LinkedList
        /// </summary>
        /// <returns></returns>
        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        /// <summary>
        /// Method to remove last node from LinkedList
        /// </summary>
        /// <returns></returns>
        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
    }
}
