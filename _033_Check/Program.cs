using System;

namespace _033_Check
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("국어 점수를 입력하세요.");
            int language = int.Parse(Console.ReadLine());

            Console.Write("영어 점수를 입력하세요.");
            int english = int.Parse(Console.ReadLine());

            Console.Write("수학 점수를 입력하세요.");
            int math = int.Parse(Console.ReadLine());

            Console.Write("과학 점수를 입력하세요.");
            int science = int.Parse(Console.ReadLine());

            Console.WriteLine("국어 : {0}\t영어 : {1}\t수학 : {2}\t과학 : {3}", language, english, math, science);
            Console.WriteLine("총점 : {0}\t평균 : {1}", language + english + math + science, (language + english + math + science) / 4);
        }
    }
}
