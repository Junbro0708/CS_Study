using System;

namespace _087_class_extension
{
    class AA
    {
        public void View(string str)
        {
            Console.WriteLine("PrintAA {0}", str);
        }
    }

    static class Util
    {
        public static void Print(this AA aa, string str)
        {
            aa.View(str);
        }

        public static void Sum(this int a)
        {
            Console.WriteLine("{0} + {1} = {2}", a, a, a + a);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            AA aa = new AA();

            Util.Print(aa, "Hello");
            aa.Print("Hello"); // 이게 가능..

            Util.Sum(10);
            10.Sum(); // 매개변수에 this 키워드를 통해 클래스 확장
        }
    }
}
