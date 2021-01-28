using System;

namespace _058_Func
{
    class MainClass
    {
        // 함수의 형태1 리턴형(x) 파라미터(x)

        static void InitTitle() // main 함수가 static으로 되어있기 때문에 static을 써줘야 하는걸로 일단 이해
        {
            Console.WriteLine("짝수 홀수 보여주기");
        }

        static void PrintEven()
        {
            for(int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even : {0}", i);
                if (i % 2 != 0)
                    Console.WriteLine("Odd : {0}", i);
            }
        }

        // 함수의 형태2 리턴형(o) 파라미터(x)

        static int Add()
        {
            int a = 0;
            return a++;
        }

        // 함수의 형태3 리턴형(o) 파라미터(o)

        static int Square(int i)
        {
            return i * i;
        }

        // 함수의 형태4 리턴형(x) 파라미터(o)



        public static void Main(string[] args)
        {
            Console.WriteLine(Add());
            Console.WriteLine(Square(5));
        }
    }
}
