using System;

/*------------------
 * Name: _026_ToString()
 * DESC: parse 연산자 기초
------------------- */

namespace _026_Data_parse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string strA = "100";
            string strB = "3.141592";
            string strC = "3.141592659169274";

            int parseA = int.Parse(strA);
            float parseB = float.Parse(strB);
            decimal parseC = decimal.Parse(strC);

            Console.WriteLine("{0}", parseA);
            Console.WriteLine("{0}", parseB);
            Console.WriteLine("{0}", parseC);
        }
    }
}
