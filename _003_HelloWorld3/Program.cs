using System;

/*------------------
 * Name: _003_HelloWorld
 * DESC: 다양한 형태의 메인 함수
------------------- */

namespace _003_HelloWorld3
{
    class MainClass
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("string[] args");
        //}

        //public static void Main()
        //{
        //    Console.WriteLine("static void Main");
        //}

        public static int Main()
        {
            Console.Write("Hello!");
            Console.WriteLine("AAA{0} BBB{1}", 1, "ggg");

            return 0;
        }

        // 결론은 메인 함수는 하나만 존재하지만, 다양한 특성을 지닐 수 있음
    }
}
