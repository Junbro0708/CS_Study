using System;

namespace _073_Array_Func2
{
    class MainClass
    {
        static int[] CreateIntArray(int size)
        {
            int[] creArray = new int[size];

            for (int i = 0; i < creArray.Length; i++)
                creArray[i] = 0;

            return creArray;
        }

        static string[] CreateStringArray(int size)
        {
            string[] creArray = new string[size];

            for (int i = 0; i < creArray.Length; i++)
                creArray[i] = string.Empty;

            return creArray;
        }

        public static void Main(string[] args)
        {
            int[] arrNum = CreateIntArray(3);
            string[] arrStr = CreateStringArray(5);
        }
    }
}
