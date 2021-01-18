using System;

/*------------------
 * Name: _025_ToString()
 * DESC: ToSTring 연산자 기초
------------------- */

namespace _025_Data_ToString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 100;
            float b = 3.141592f;

            string c = a.ToString();
            string d = b.ToString();

            Console.WriteLine("c : {0} Type : {1}", c, c.GetType());
            Console.WriteLine("d : {0} Type : {1}", d, d.GetType());
        }
    }
}
