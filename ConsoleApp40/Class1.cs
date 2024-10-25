using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Queue
    {
        int front;
        int rear;
        int size;
        int[] qearr;
        public Queue(int len)
        {
            size = len;
            front = -1;
            rear = -1;
            qearr = new int[size];
        }
        public bool ISEmtay()
        {
            return rear== - 1;
        }
        public bool IsFull()
        {
            return rear==size-1;
        }
        public void Enqeueu(int element)
        {
            qearr[++rear]=element;
            if (front == -1)
                front++;
        }
        public int Dequeue()
        {
            int x = qearr[front];
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else
                front++;
            return x;
        }
        public void Display()
        {
            Console.WriteLine("The elements of Queue is");
            for (int i = front;i<=rear;i++)
            {
                Console.WriteLine(qearr[i]);
            }
        }
    }
}
