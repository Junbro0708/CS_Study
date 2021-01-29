using System;

namespace _066_Func_params
{
    class MainClass
    {
        static int Total(params int[] values)
        {
            int total = 0;

            for (int i = 0; i < values.Length; i++)
                total += values[i];

            return total;
        }
        static void CheckValue(params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
                Console.WriteLine("Value : {0} Type : {1}", values[i], values[i].GetType());
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Total(1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 0));

            CheckValue(1.2, 3.0f, "ss", 'd');
        }
    }
}
