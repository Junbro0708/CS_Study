using System;

namespace _077_Class
{
    class AA
    {
        //멤버 변수
        int num1; //기본적으로 private 속성
        public int num2, num3;

        //멤버 함수
        public void Print()
        {
            Console.WriteLine("{0}, {1}, {2}", num1, num2, num3);
        }
        private void PrintPrivate()
        {
            Console.WriteLine("{0}, {1}, {2}", num1, num2, num3);
        }
    }
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            AA aa = new AA();
            aa.num2 = 10;
            aa.num3 = 100;
            aa.Print();
        }
    }
}
