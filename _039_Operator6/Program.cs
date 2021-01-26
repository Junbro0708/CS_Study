using System;

// 삼항 연산자 ( ? : )

namespace _039_Operator6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 0;
            bool result;

            result = (num == 0) ? true : false;
            Console.WriteLine("{0}", result);

            result = (num > 10) ? true : false;
            Console.WriteLine("{0}", result);
        }
    }
}
