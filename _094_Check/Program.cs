using System;

namespace _094_Check
{
    class CSaveNumber
    {
        private int number1 { get; set; }
        private int number2 { get; set; }

        public CSaveNumber()
        {
            number1 = 0;
            number2 = 0;
        }

        public void InputNumber(int cnt)
        {
            if(cnt == 0)
            {
                Console.WriteLine("첫 번째 수를 입력하세요.");
                number1 = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("두 번째 수를 입력하세요.");
                number2 = int.Parse(Console.ReadLine());
            }
        }

        public void PrintResult()
        {
            Console.WriteLine("{0} + {1} = {2}\n", number1, number2, (number1 + number2));
        }
    }
    class MainClass
    {
        static bool CheckEnd(int index)
        {
            bool isEnd = false;
            int temp = 0;

            Console.WriteLine("몇 번째 추가로 계산할까요? 단, 1은 OK 0은 NO 10번까지 가능", (index + 1));
            temp = int.Parse(Console.ReadLine());
            isEnd = (temp == 0);

            return isEnd;
        }

        public static void Main(string[] args)
        {
            int indexCnt = 0;
            CSaveNumber[] saveNumbers = new CSaveNumber[10];

            while (true)
            {
                saveNumbers[indexCnt] = new CSaveNumber();
                saveNumbers[indexCnt].InputNumber(0);
                saveNumbers[indexCnt].InputNumber(1);

                saveNumbers[indexCnt].PrintResult();

                indexCnt++;

                if(indexCnt>= 10 || CheckEnd(indexCnt))
                {
                    for(int i = 0; i < indexCnt; i++)
                    {
                        saveNumbers[i].PrintResult();
                    }
                    break;
                }
            }
        }
    }
}
