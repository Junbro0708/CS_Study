using System;

namespace _082_Class_inheritance
{
    class Super
    {
        protected int a;

        public void Print()
        {
            Console.WriteLine("Super");
        }
    }
    class Sub : Super
    {
        int b;

        public void Print()
        {
            Console.WriteLine("Sub {0} {1}", a, b);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Super sp = new Super();
            sp.Print();
            Sub sub = new Sub();
            sub.Print();
        }
    }
}
