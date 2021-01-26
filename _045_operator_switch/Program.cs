using System;

namespace _045_operator_switch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = 0;
            string strGrade = null;

            Console.WriteLine("점수를 입력하세요.");
            num = int.Parse(Console.ReadLine());

            switch(num / 10)
            {
                case 10:
                case 9: // ||
                    strGrade = "A";
                    break;
                case 8:
                    strGrade = "B";
                    break;
                case 7:
                    strGrade = "C";
                    break;
                case 6:
                    strGrade = "D";
                    break;
                default:
                    strGrade = "F";
                    break;
            }

            Console.WriteLine("당신의 점수는 {0}점 입니다.", strGrade);
        }
    }
}
