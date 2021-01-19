using System;

/*------------------
 * Name: _028_Reference
 * DESC: Reference의 기초
------------------- */

namespace _028_Data_Reference
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 100;
            int refNum = num;

            Console.WriteLine("{0} {1}", num == refNum, Object.ReferenceEquals(num, refNum));

            string str = "HI";
            string refStr = str;

            Console.WriteLine("{0} {1}", str == refStr, Object.ReferenceEquals(str, refStr));
        }
    }
}
