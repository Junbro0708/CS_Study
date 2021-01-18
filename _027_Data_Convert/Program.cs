using System;

/*------------------
 * Name: _027_Convert
 * DESC: convert 연산자 기초
------------------- */

namespace _027_Data_Convert
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string strA = "100";
            string strB = "3.141592";
            string strC = "3.141592659169274";

            int convertA = Convert.ToInt32(strA);
            float convertB = Convert.ToSingle(strB);
            decimal convertC = Convert.ToDecimal(strC);

            Console.WriteLine("{0}", convertA);
            Console.WriteLine("{0}", convertB);
            Console.WriteLine("{0}", convertC);
        }
    }
}
