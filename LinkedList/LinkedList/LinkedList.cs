using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProblem
{
    public class LinkedList
    {
        internal Node head;

        /// <summary>
        /// Adding elements at the end of the LinkedList
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
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
                var firstHead = this.head;
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
                firstHead.next = head;
                head = firstHead;

                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }

        /// <summary>
        /// Method to remove first node from LinkedList
        /// </summary>
        /// <returns></returns>
        internal Node RemoveFirstNode()
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
        internal Node RemoveLastNode()
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

        /// <summary>
        /// Method to search specific value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }

        /// <summary>
        /// Method to delete particular node
        /// </summary>
        /// <param name="data"></param>
        public void DeleteNode(int data)
        {
            Node temp = head, prev = null;
            if (temp != null && temp.data == data)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;

            prev.next = temp.next;
        }

        /// <summary>
        /// Method to display size of Linked List
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Node temp = head;
            int size = 0;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }
    }
}
