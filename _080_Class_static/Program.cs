using System;

namespace _080_Class_static
{
    class AA
    {
        public static int a;
        public static int b;
        public int num;

        public static readonly int c = 200; // readonly는 읽기 전용으로 상수화된다고 보면된다.

        public static void Print()
        {
            Console.WriteLine("a : {0} b : {1}", a, b);
            // num = 100;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            AA.a = 100;
            AA.b = 200;
            //AA.c = 300;

            AA.Print();
        }
    }
}
