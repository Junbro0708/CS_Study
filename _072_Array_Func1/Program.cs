using System;

namespace _072_Array_Func1
{
    class MainClass
    {
        static void SwapArray(int oriIndex, int desIndex, int[] array) 
        {
            int temp = array[oriIndex];
            array[oriIndex] = array[desIndex];
            array[desIndex] = temp;
        }

        public static void Main(string[] args)
        {
            int[] arrNum = new int[] { 1, 2, 3, 4 };

            foreach (int temp in arrNum)
                Console.Write("{0} ", temp);

            SwapArray(1, 2, arrNum);

            Console.WriteLine();

            foreach (int temp in arrNum)
                Console.Write("{0} ", temp);
        }
    }
}
