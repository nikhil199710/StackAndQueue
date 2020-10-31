using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace StacksAndQueues
{
    public class Stacks
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
            Node temp = top;
            Console.WriteLine("\nDisplaying the Stack");
            if (temp == null)
            {
                Console.WriteLine("Empty Stack");
            }
            //Loop runs until null value is obtained in data.
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        /// <summary>
        /// Displaying top value in stack
        /// </summary>
        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Empty Stack");
            }
            Console.WriteLine("Displaying top value in stack");
            Console.WriteLine(top.data);
            return top.data;
        }
        public void Pop()
        {
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine("Empty Stack");
            }
            Console.WriteLine("Removing the top value from stack");
            //moving the pointer of top to next node
            top = temp.next;
            Display();
        }
        /// <summary>
        /// Removes all element from stack by calling peek and pop
        /// </summary>
        public void IsEmpty()
        {
            Console.WriteLine("Removing all the values from stack");
            while (top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}