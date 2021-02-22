using System;

namespace _088_struct
{
    struct AA
    {
        public int x;
        public int y;

        public AA(int x, int y) // 생성자에 매개변수(파라미터)가 없으면 오류가 발생
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("x : {0}, y : {1}", x, y);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            AA aa;
            aa.x = 100;
            aa.y = 200;
            aa.Print();

            AA aaa = new AA(10, 20);
            aaa.Print();

            AA copyAA = aa;
            copyAA.x = 1000;
            copyAA.y = 2000;
            copyAA.Print();

            aa.Print();
        }
    }
}
