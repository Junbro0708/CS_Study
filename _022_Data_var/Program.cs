using System;

/*------------------
 * Name: _022_var
 * DESC: var 데이터형 활용
------------------- */

namespace _022_Data_var
{
    class MainClass
    {
        // 지역 변수에만 사용이 가능하기 때문에 여기서 사용 불가

        public static void Main(string[] args)
        {
            var a = 100; // 선언과 동시에 초기화

            Console.WriteLine("a : {0}", a.GetType());
        }
    }
}
