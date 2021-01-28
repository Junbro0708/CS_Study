using System;

namespace _062_Func_Swap
{
    class MainClass
    {
        static public void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("ValueSwap");
            Console.WriteLine("num1 : {0} num2 : {1}", a, b);
        }

        static public void RefSwap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("RefSwap");
            Console.WriteLine("num1 : {0} num2 : {1}", a, b);
        }
        public static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 5;

            Swap(num1, num2);
            Console.WriteLine("num1 : {0} num2 : {1}", num1, num2);

            RefSwap(ref num1, ref num2);
            Console.WriteLine("num1 : {0} num2 : {1}", num1, num2);
        }
    }
}
