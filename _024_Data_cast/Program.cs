using System;

/*------------------
 * Name: _024_cast
 * DESC: cast 연산자 기초
------------------- */

namespace _024_Data_cast
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 100;
            double dnum = num; // 작은 것을 큰 곳에 넣는 것은 암묵적 형변환이 이루어지기 때문에 문제가 되지 않는다.
            Console.WriteLine("dnum : {0}", dnum);

            double dnum2 = 135682323;
            int num2 = (int)dnum2; // 큰 것은 작은 곳에 넣는 것은 명시적 형변환이 필요하다.
            Console.WriteLine("num2 : {0}", num2);

        }
    }
}
