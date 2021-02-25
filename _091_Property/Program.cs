using System;

namespace _091_Property
{
    class AA
    {
        private int num;

        public int NUM
        {
            get { return num; }
            set { num = value; } // set을 만들지 않으면 읽기 전용으로 치부
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            AA aa = new AA();
            aa.NUM = 100;

            Console.WriteLine("aa.NUM : " + aa.NUM);
        }
    }
}
