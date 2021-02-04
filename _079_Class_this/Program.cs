using System;

namespace _079_Class_this
{
    class MainClass
    {
        class AA
        {
            int a;

            public AA(int a)
            {
                this.a = a;
                Console.WriteLine("{0}", this.a);
            }

            public void Print()
            {
                int a = 100;
                this.a = 1000;

                Console.WriteLine("a : {0} / this.a : {1}", a, this.a);
            }
        }
        public static void Main(string[] args)
        {
            AA aa = new AA(3);
            aa.Print();
        }
    }
}
