using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackAndQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Stack Operations");
            ArrayStack<string> stack = new ArrayStack<string>(5);
            stack.Push("Hello");
            stack.Push("There");
            stack.Push("Everyone");
            stack.Peek();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Console.WriteLine();

            Console.WriteLine("Linked List Stack operations");
            LinkedListStack<int> lls = new LinkedListStack<int>();
            lls.Push(new Node<int>(5));
            lls.Pop();
            Console.WriteLine();
            Console.WriteLine("List Queue Operations");
            MyListQueue<int> list = new MyListQueue<int>();
            list.Enqueue(1);
            list.Enqueue(2);
            list.Enqueue(3);
            list.Enqueue(4);
            list.Enqueue(5);
            list.Dequeue();
            list.Dequeue();
            list.Dequeue();
            list.Dequeue();
            list.Dequeue();
            list.Dequeue();

            Console.WriteLine();

            Console.WriteLine("Linked List Queue Operations");
            MyLinkedListQueue<int> linkedQueue = new MyLinkedListQueue<int>();
            linkedQueue.Enqueue(1);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Dequeue();
            linkedQueue.Dequeue();
            linkedQueue.Dequeue();
            linkedQueue.Dequeue();
        }
    }
}
