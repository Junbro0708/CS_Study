using System;

namespace _070_Array_Multi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] arrNums = new int[3, 2];

            arrNums[0, 0] = 0;
            arrNums[0, 1] = 1;

            arrNums[1, 0] = 2;
            arrNums[1, 1] = 3;

            arrNums[2, 0] = 4;
            arrNums[2, 1] = 5;

            foreach(int temp in arrNums)
            {
                Console.Write("{0} ", temp);
            }
        }
    }
}
