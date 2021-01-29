using System;

namespace _067_Check
{
    class MainClass
    {
        static void Start()
        {
            Console.WriteLine("성정 프로그램 - Method");
        }

        static void Input(ref int kor, ref int mat, ref int eng)
        {
            Console.Write("국어 성적을 입력하세요 : ");
            kor = int.Parse(Console.ReadLine());

            Console.Write("수학 성적을 입력하세요 : ");
            mat = int.Parse(Console.ReadLine());

            Console.Write("영어 성적을 입력하세요 : ");
            eng = int.Parse(Console.ReadLine());

            Console.WriteLine("국어 : {0} 수학 : {1} 영어 : {2}", kor, mat, eng);
        }

        static int Total(int kor, int mat, int eng)
        {
            return kor + mat + eng;
        }

        static void Average(int total, out float average)
        {
            average = total / 3f;
        }

        public static void Main(string[] args)
        {
            int kor = 0;
            int mat = 0;
            int eng = 0;
            int total;
            float average;

            Start();
            Input(ref kor, ref mat, ref eng);
            total = Total(kor, mat, eng);
            Average(total, out average);

            Console.WriteLine("total : {0} average : {1}", total, average);
        }
    }
}
