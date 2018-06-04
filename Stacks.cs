using System;

namespace BasicStackAndQueueOperations
{
    public class ArrayStack<T>
    {
        private int Max;
        public static int currentPosition;
        public T[] arrayStack;

        public ArrayStack(int size)
        {
            Max = size;
            arrayStack = new T[Max];
            currentPosition = -1;
        }

        public void Push(T data)
        {
            if (currentPosition >= Max)
                Console.WriteLine("Stack overflow");
            else
            {
                currentPosition++;
                arrayStack[currentPosition] = data;
                Console.WriteLine($"{data} was pushed on the stack.");
            }
        }

        public void Pop()
        {
            if (currentPosition < 0)
            {
                Console.WriteLine("Stack underflow, stack is empty");
                return;
            }

            T temp = arrayStack[currentPosition];
            arrayStack[currentPosition] = default(T);
            currentPosition--;
            Console.WriteLine($"{temp} was popped off the stack.");
        }

        public bool GetIsStackEmpty() { return currentPosition < 0; }

        public void Peek()
        {
            if (GetIsStackEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            };
            Console.WriteLine($"{arrayStack[currentPosition]} is at the top of this stack.");
            
        }
    }

    class LinkedListStack<T>
    {
        public Node<T> top;

        public LinkedListStack()
        {
            top = null;
        }

        public void Push(Node<T> newNode)
        {
            if (top == null)
                top = newNode;
            newNode.Next = top;
            top = newNode;
            Console.WriteLine($"{newNode.Data} successfully pushed to stack.");
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            Console.WriteLine($"{top.Data} is being popped off the stack.");
            top = top.Next;
            Console.WriteLine("Pop was successful.");
        }

        public T Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }

            return top.Data;
        }

    }
}