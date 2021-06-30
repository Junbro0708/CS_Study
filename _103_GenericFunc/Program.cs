using System;

namespace _103_GenericFunc
{
    class MainClass
    {
        static void GenericPrint<T>(T data)
        {
            Console.WriteLine("data : {0}", data);
        }

        static void GenericPrint<T>(T[] arrData)
        {
            for(int i = 0; i < arrData.Length; i++)
            {
                Console.WriteLine("data : {0}", arrData[i]);
            }
        }

        public static void Main(string[] args)
        {
            int a = 1;
            float b = 10.3f;
            string c = "Hello";

            int[] arrA = { 1, 3, 4, 5, 6 };

            GenericPrint(a);
            GenericPrint(b);
            GenericPrint(c);

            GenericPrint(arrA);
        }
    }
}
