using System;

namespace _063_Func_Out
{
    class MainClass
    {
        static void InitNum(out int addNum)
        {
            addNum = 100;
        }

        static void InitRefNum(ref int refNum)
        {
            refNum = 100;
        }
        public static void Main(string[] args)
        {
            int a;
            int b = 0;

            InitNum(out a); // out 키워드는 초기화를 해도 되지만, 안해도됨
            InitRefNum(ref b); // ref 키워드는 초기화를 해줘야한다.
        }
    }
}
