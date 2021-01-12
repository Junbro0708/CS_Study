using System;

/*------------------
 * Name: _002_HelloWorld
 * DESC: 메인 함수의 파라미터 보기
------------------- */

namespace _002_HelloWorld2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                Console.WriteLine("Hello World : " + args[0]);
            } else
            {
                Console.WriteLine("Hello World: args Lenght = 0");
            }

            Console.ReadKey();
        }
    }
}
