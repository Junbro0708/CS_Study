using System;

namespace _055_Check
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int cnt = 0;

            for (int i = 0; i < 5; i++)
            {
                int a = rnd.Next(1, 100);
                int b = rnd.Next(1, 100);
                Console.WriteLine("{0}: 다음 두 수의 합은 몇? (총 5 문제)", i + 1);
                Console.WriteLine("{0} + {1} = ??", a, b);
                int answer = int.Parse(Console.ReadLine());
                if (answer == a + b)
                {
                    Console.WriteLine("==정답==");
                    cnt++;
                }
                else
                    Console.WriteLine("오답(정답은 : {0})", a + b);
            }
            Console.WriteLine("맞힌 횟수는 {0}번 입니다.", cnt);
        }
    }
}
