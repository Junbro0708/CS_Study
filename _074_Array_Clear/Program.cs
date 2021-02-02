using System;

namespace _074_Array_Clear
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = new int[3];

            Array.Clear(array, 0, array.Length);

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            foreach (int temp in array)
                Console.Write("{0} ", temp);
        }
    }
}
