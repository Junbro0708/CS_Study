using System;

namespace _048_Random
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int a = rnd.Next(0, 100); 
            int b = rnd.Next(0, 100); // min <= rnd < max

            Console.WriteLine("{0} {1}", a, b);
            
        }
    }
}
