using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace StacksAndQueues
{
    class Stacks
    {
        //Defining a node which is assigned null value in constructor
        //it is like a head and used to point to first node.
        public Node top;
        /// <summary>
        /// Initializing node top to null
        /// </summary>
        public Stacks()
        {
            top = null;
        }
        /// <summary>
        /// Pushing the Elements into the Stack, using LinkedList, DisplayInMethod Approach
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            //object of node is created and initialized with data
            Node node = new Node(data);
            //address of new node is filled with top, hence node will point to node
            node.next = top;
            //changing the address in top to that of node, hence node will become new top
            //when new node, will point to top, it will be addressed to old value added, acting now as top
            top = node;
            Console.WriteLine("Element Inserted In Stack:\t{0}", top.data);

        }
        /// <summary>
        /// Displaying the stack
        /// </summary>
        public void Display()
        {
            Console.WriteLine("\nDisplaying the Stack");
            //Loop runs until null value is obtained in data.
            while (top != null)
            {
                Console.WriteLine(top.data);
                top = top.next;
            }
        }
    }
}