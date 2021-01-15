using System;

/*------------------
 * Name: _020_Data_nullable
 * DESC: nullable 데이터형 활용
------------------- */

namespace _021_Data_nullable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double? a = 3.14;
            char? b = 'a';

            int num = 10;
            int? c = num;

            bool? isFlag = null;

            Console.WriteLine("a : {0}", a);
            Console.WriteLine("b : {0}", b);
            Console.WriteLine("c : {0}", c);

            Console.WriteLine("isFlag : {0}", isFlag);
            Console.WriteLine("isFlag : {0}", isFlag.HasValue);

            if (isFlag.HasValue)
                Console.WriteLine("isFlag HasValue: {0}", isFlag.Value);
        }
    }
}
