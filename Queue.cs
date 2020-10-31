using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        //creating the node head
        public Node head;
        /// <summary>
        /// adding the values in queue
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(int data)
        {
            //creating and initializing node with data
            Node node = new Node(data);
            Node temp = head;
            //if head is null,first value of node is addressed to head
            //head contains the address of first element
            if (head == null)
            {
                head = node;
            }
            else
            {
                //last element is taken out in queue and node address is passed in last node.
                Node lastNode = GetLastNode(temp);
                lastNode.next = node;
            }
            Console.WriteLine("Element inserted in queue:\t{0}", node.data);

        }
        /// <summary>
        /// Getting the last element of queue
        /// </summary>
        /// <param name="temp"> temp is the node which is passed to find out last node, by iteration</param>
        /// <returns>temp is returned with reference to last node</returns>
        public Node GetLastNode(Node temp)
        {
            if (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        /// <summary>
        /// Displays the queue
        /// </summary>
        public void DisplayQueue()
        {
            Console.WriteLine("\nDisplaying the Queue");
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("empty queue");
            }
            else
            {
                //loop is running, until the last element of queue becomes null
                //prints the queue
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        /// <summary>
        /// Displaying first element in the queue
        /// </summary>
        /// <returns></returns>
        public int QueuePeek()
        {
            if (head == null)
            {
                Console.WriteLine("Empty Queue");
            }

            Console.WriteLine("Peek method for queue");
            Console.WriteLine(head.data);
            return head.data;
        }
        /// <summary>
        /// removing 1st element from the queue
        /// </summary>
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Empty Queue");
            }
            //passing the address of 2nd element to the head, hence head will directly point to 2nd element and 1st element is abandoned.
            head = head.next;
            DisplayQueue();


        }
        public void IsEmptyQueue()
        {
            Node temp = head;
            while (temp != null)
            {
                QueuePeek();
                Dequeue();
                temp = temp.next;
            }
        }
    }
}