using System;

namespace _068_Array_Init
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arrNum = new int[3];

            arrNum[0] = 1;
            arrNum[1] = 2;
            arrNum[2] = 3;

            for (int i = 0; i < arrNum.Length; i++)
                Console.WriteLine("arrNum[{0}] : {1}", i, arrNum[i]);

            Console.WriteLine("arrNum GetType : {0}", arrNum.GetType());
        }
    }
}
