using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of queue:");
            int len=int.Parse(Console.ReadLine());
            Queue que = new Queue(len);
            Queue queOdd=new Queue(len);

            for(int i = 0; i < len; i++)
            {
                if (que.IsFull())
                {
                    Console.WriteLine("Queue is Full");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the element:");
                    int x = int.Parse(Console.ReadLine());
                    que.Enqeueu(x);
                }
            }
            que.Display();

            for(int i = 0; i < len; i++)
            {
                int elim = que.Dequeue();
                if (elim % 2 != 0)
                {
                    queOdd.Enqeueu(elim);
                }
            }           
            queOdd.Display();










        }
    }
}
