using System;

namespace _081_Class_parameter
{
    class AA
    {
        public int a;
        public int b;

        public AA()
        {
            int a = 0;
            int b = 0;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("a: {0} b: {1}", a, b);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            AA aa = new AA();
            aa.Print();

            CopyRefClass(aa);
            aa.Print();

            AA aaa = CopyDeepClass(aa);
            aaa.Print();
            aa.Print();
        }

        static void CopyRefClass(AA aa)
        {
            AA refAA = aa;
            refAA.a = 100;
            refAA.b = 10000;
        }

        static AA CopyDeepClass(AA aa)
        {
            AA tempAA = new AA();

            tempAA.a = aa.a;
            tempAA.b = aa.b;
            tempAA.a = 0;

            return tempAA;
        }
    }
}
