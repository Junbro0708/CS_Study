using System;

namespace _076_Check2
{
    class MainClass
    {
        static int InputNumber(int count)
        {
            int temp = 0;

            if (count == 0)
                Console.Write("첫 번째 수를 입력하세요. ");
            else
                Console.Write("두 번째 수를 입력하세요. ");

            temp = int.Parse(Console.ReadLine());

            return temp;
        }
        static void PrintResult(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        static bool CheckEnd()
        {
            bool isEnd = false;
            int temp = 0;

            Console.Write("추가로 계산할까요? (1 : OK / 0 : NO, 계산은 10번 까지 가능) ");
            temp = int.Parse(Console.ReadLine());

            isEnd = (temp == 0);

            return isEnd;
        }

        public static void Main(string[] args)
        {
            int[] arrA = new int[10];
            int[] arrB = new int[10];
            int indexCount = 0;

            while (true)
            {
                arrA[indexCount] = InputNumber(0);
                arrB[indexCount] = InputNumber(1);

                PrintResult(arrA[indexCount], arrB[indexCount]);

                indexCount++;

                if(indexCount >= 10 || CheckEnd())
                {
                    for(int i =0; i < indexCount; i++)
                    {
                        PrintResult(arrA[i], arrB[i]);
                    }
                    break;
                }
            }
        }
    }
}
