using System;
using System.Net.Http.Headers;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack and Queues");
            Console.WriteLine("Stack Program");
            //Creating object for stacks
            Stacks stacks = new Stacks();
            //pushing values in stacks
            stacks.Push(70);
            stacks.Push(30);
            stacks.Push(56);
            stacks.Push(16);
            stacks.Display();
            //peeking out the top value
            stacks.Peek();
            //poping out the top value
            stacks.Pop();
            //Removing all elements from stack
            stacks.IsEmpty();
        }
    }
}