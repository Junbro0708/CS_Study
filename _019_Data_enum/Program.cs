using System;

/*------------------
 * Name: _019_Data_enum
 * DESC: enum의 데이터형 기초
------------------- */

namespace _019_Data_enum
{
    class MainClass
    {
        enum DAY_OF_WEEK
        {
            SUN,
            MON,
            TUE,
            WED,
            THU,
            FRI,
            SAT
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.SUN, (int)DAY_OF_WEEK.SUN);
            Console.WriteLine("{0} {1}", DAY_OF_WEEK.MON, (int)DAY_OF_WEEK.MON);
        }
    }
}
