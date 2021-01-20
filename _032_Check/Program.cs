using System;

namespace _032_Check
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 100;
            string b = "AAA";
            float c = 0.123f;
            char d = 'A';

            Console.WriteLine("a : {0}, {1}", a, a.GetType());
            Console.WriteLine("b : {0}, {1}", b, b.GetType());
            Console.WriteLine("c : {0}, {1}", c, c.GetType());
            Console.WriteLine("d : {0}, {1}", d, d.GetType());
        }
    }
}
