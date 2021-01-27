using System;
using System.Threading;

namespace CheckPoint01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            const string LINE = "----------------------------------------";
            const int END_LINE = 40;
            const int DELAY_TIME = 20;

            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;

            while (true)
            {
                Thread.Sleep(DELAY_TIME); // 딜레이 1000이 1초
                Console.Clear(); // 화면 지우기

                runA++;
                runB++;
                runC++;
                runD++;

                int rndNum = rnd.Next(0, 4);

                switch (rndNum)
                {
                    case 0:
                        runA++;
                        break;
                    case 1:
                        runB++;
                        break;
                    case 2:
                        runC++;
                        break;
                    case 3:
                        runD++;
                        break;
                }

                Console.WriteLine(LINE);

                for (int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.Write("1");

                for (int i = END_LINE; i > runA; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runB; i++)
                    Console.Write(" ");
                Console.Write("2");

                for (int i = END_LINE; i > runB; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runC; i++)
                    Console.Write(" ");
                Console.Write("3");

                for (int i = END_LINE; i > runC; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runD; i++)
                    Console.Write(" ");
                Console.Write("4");

                for (int i = END_LINE; i > runD; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                Console.WriteLine(LINE);

                if(runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
                {
                    int res = 0;
                    string strResult = "결과 : {0}번 선수 우승!!";

                    if (runA >= END_LINE)
                        res = 1;
                    else if (runB >= END_LINE)
                        res = 2;
                    else if (runC >= END_LINE)
                        res = 3;
                    else
                        res = 4;

                    Console.WriteLine(strResult, res);

                    Console.WriteLine("다시 플레이 하려면 0번을 눌러주세요.");

                    if (0 == int.Parse(Console.ReadLine()))
                    {
                        runA = 0;
                        runB = 0;
                        runC = 0;
                        runD = 0;
                    }
                    else
                        break;
                }
            }
        }
    }
}
