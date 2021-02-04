using System;

namespace _078_Class_Constructor
{
    class AA
    {
        int a;
        float f;

        public AA()
        {
            a = 0;
            f = 0f;
            Console.WriteLine(" Call Constructor ");
            Console.WriteLine("a : {0} ", a);
            Console.WriteLine("f : {0} ", f);
        }
        public AA(int _a, float _f = 0f)
        {
            a = _a;
            f = _f;
            Console.WriteLine(" Call Constructor ");
            Console.WriteLine("a : {0} ", a);
            Console.WriteLine("f : {0} ", f);
        }
        ~AA()
        {
            Console.WriteLine(" Call Destructor ");
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            AA aa = new AA();
            AA aaa = new AA(3, 4f);
        }
    }
}
