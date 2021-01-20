using System;

/*------------------
 * Name: _030_ReadLine
 * DESC: ReadLine의 기초
------------------- */

namespace _030_ReadLine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하세요.");
            int num = int.Parse(Console.ReadLine()); // string으로 들어오기 때문에 파싱 형변환

            Console.WriteLine("입력한 수는 {0}", num);
        }
    }
}
