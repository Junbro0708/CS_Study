using System;

namespace _083_Class_inheritance
{
    class Super
    {
        protected int a;

        public Super()
        {
            a = 100;
            Console.WriteLine("Call Super 생성자");
        }

        ~Super()
        {
            Console.WriteLine("Call Super 소멸자");
        }
    }

    class Sub : Super
    {
        public Sub()
        {
            a = 100;
            Console.WriteLine("Call Sub 생성자");
        }

        ~Sub()
        {
            Console.WriteLine("Call Sub 소멸자");
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Sub sub = new Sub();
        }
    }
}
