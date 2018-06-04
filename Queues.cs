using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackAndQueueOperations
{
    class MyListQueue<T>
    {
        public static int Front = 0;
        public static int Rear = -1;
        public List<T> ListQueue;

        public MyListQueue()
        {
             ListQueue = new List<T>();
        }

        public void Enqueue(T item)
        {
            Rear++;
            ListQueue.Add(item);
            Console.WriteLine($"{item} was successfully enqueued");
        }

        public void Dequeue()
        {
            if (Rear == -1)
            {
                Console.WriteLine("The list is empty, nothing to dequeue.");
                return;
            }
            T item = ListQueue[Front];
            ListQueue.RemoveAt(Front);
            Rear--;
            Console.WriteLine($"{item} was successfully dequeued.");
        }
    }

    class MyLinkedListQueue<T>
    {
        public static Node<T> Front = null;
        public static Node<T> Rear = null;
        public LinkedList<T> ListQueue;
        public Node<T> top;

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (Front == null && Rear == null)
            {
                Front = newNode;
                Rear = newNode;
            }
            else
            {
                Rear.Next = newNode;
                Rear = newNode;
            }
            Console.WriteLine($"{item} was successfully enqueued");
        }

        public void Dequeue()
        {
            if (Front == null)
            {
                Console.WriteLine("The list is empty, nothing to dequeue.");
                return;
            }

            Node<T> temp = Front;
            Front = Front.Next;
            temp.Next = null;
            Console.WriteLine($"{temp.Data} was successfully dequeued.");
        }
    }
}
