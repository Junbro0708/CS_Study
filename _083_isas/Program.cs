using System;

namespace _083_isas
{
    class Base
    {
        int num;

        public void Print()
        {
            Console.WriteLine("num : {0}", num);
        }
    }

    class AA : Base
    {
        int a;

        public void PrintA()
        {
            Console.WriteLine("a : {0}", a);
        }
    }

    class BB : Base
    {
        int b;

        public void PrintB()
        {
            Console.WriteLine("b : {0}", b);
        }
    }
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            Base _base = new Base();
            _base.Print();

            Base aa = new AA();
            aa.Print();

            if(aa is AA)
            {
                Console.WriteLine("aa = AA");
            }else if(aa is BB)
            {
                Console.WriteLine("aa == BB");
            }
        }
    }
}
