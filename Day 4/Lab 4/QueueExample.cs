using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_4
{
    internal class QueueExample
    {
        public static void Main()
        {
            Queue q = new Queue();
            q.Enqueue("Benz");
            q.Enqueue("Bmw");
            q.Enqueue("Audi");
            q.Enqueue("Lamborgini");
            q.Enqueue("Messaratti");
            Console.WriteLine("after adding the elements in the queue:");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }
    }
}

