using System;

namespace _056_Check
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer = rnd.Next(1, 100);
            int cnt = 0;
            bool check = true;
            while (check)
            {
                Console.WriteLine("1 ~ 99 사이의 어떤 숫자일까요? (단, 0은 나가기)");
                int a = int.Parse(Console.ReadLine());


                if (a == 0)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    break;
                }
                else if (a < answer)
                {
                    cnt++;
                    Console.WriteLine("입력한 수는 정답보다 작아요");
                }
                else if (a > answer)
                {
                    cnt++;
                    Console.WriteLine("입력한 수는 정답보다 커요");
                }
                else if (a == answer)
                {
                    cnt++;
                    Console.WriteLine("=== 정답입니다 ===");
                    Console.WriteLine("총 {0}번 시도", cnt);
                    break;
                }
            }
        }
    }
}
