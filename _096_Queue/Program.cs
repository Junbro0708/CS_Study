using System;
using System.Collections;

namespace _096_Queue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            for(int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("queue data : " + queue.Peek());

            while(queue.Count > 0)
            {
                Console.WriteLine("queue data : {0}, count : {1}", queue.Dequeue(), queue.Count);
            }

            int[] arr = { 100, 200, 300 };
            Queue queue1 = new Queue(arr);

            foreach(object data in queue1)
            {
                Console.WriteLine(data);
            }
        }
    }
}
