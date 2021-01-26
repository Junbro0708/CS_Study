using System;

namespace _046_operator_switch2
{
    class MainClass
    {
        enum DAY_OF_WEEK
        {
            MON,
            TUE,
            WED,
            TUR,
            FRI,
            SAT,
            SUN
        }

        public static void Main(string[] args)
        {
            DAY_OF_WEEK dayOfWeek = DAY_OF_WEEK.FRI;
            string dayString = "";

            switch (dayOfWeek)
            {
                case DAY_OF_WEEK.MON:
                    dayString = "월";
                    break;
                case DAY_OF_WEEK.TUE:
                    dayString = "화";
                    break;
                case DAY_OF_WEEK.WED:
                    dayString = "수";
                    break;
                case DAY_OF_WEEK.TUR:
                    dayString = "목";
                    break;
                case DAY_OF_WEEK.FRI:
                    dayString = "금";
                    break;
                case DAY_OF_WEEK.SAT:
                    dayString = "토";
                    break;
                case DAY_OF_WEEK.SUN:
                    dayString = "일";
                    break;
                default:
                    break;
            }

            Console.WriteLine(dayString);
        }
    }
}
