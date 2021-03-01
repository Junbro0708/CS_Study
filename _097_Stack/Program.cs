using System;
using System.Collections;

namespace _097_Stack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            for(int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("stack data : " + stack.Peek());

            while(stack.Count > 0)
            {
                Console.WriteLine("stack data : {0} stack count : {1}", stack.Pop(), stack.Count);
            }

            int[] arr = { 100, 200, 300 };
            Stack stack1 = new Stack(arr);

            foreach(object data in stack1)
            {
                Console.WriteLine(data);
            }
        }
    }
}
