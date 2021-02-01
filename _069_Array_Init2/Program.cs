using System;

namespace _069_Array_Init2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arrNum = new int[3];
            int[] arrNum2 = new int[] { 0, 1, 2 };
            int[] arrNum3 = new int[3] { 0, 1, 2 };
            int[] arrNum4 = { 0, 1, 2 }; // 다 같은 뜻

            string[] arrWeek = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            for(int i =0; i < arrNum.Length; i++)
            {
                arrNum[i] = i;
                Console.WriteLine("arrNum[{0}] : {1}", i, arrNum[i]);
            }

            foreach(int temp in arrNum2)
            {
                Console.WriteLine("{0}", temp);
            }

            foreach(string tempStr in arrWeek)
            {
                Console.Write("{0} ", tempStr);
            }
        }
    }
}
