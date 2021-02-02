using System;
using System.Linq;

namespace _075_Check
{
    class MainClass
    {
        const int MAX = 3;

        static void InputID(int[] ID, int index)
        {
            Console.Write("학생 ID를 입력하세요. ");
            ID[index] = int.Parse(Console.ReadLine());
        }
        static void InputKor(int[] kor, int index)
        {
            Console.Write("국어 점수를 입력하세요. ");
            kor[index] = int.Parse(Console.ReadLine());
        }
        static void InputMath(int[] math, int index)
        {
            Console.Write("수학 점수를 입력하세요. ");
            math[index] = int.Parse(Console.ReadLine());
        }
        static void InputEng(int[] eng, int index)
        {
            Console.Write("영어 점수를 입력하세요. ");
            eng[index] = int.Parse(Console.ReadLine());
        }
        static void PrintID(int max, int[] ID)
        {
            for (int i = 0; i < max; i++)
                Console.WriteLine("학생 ID : {0}", ID[i]);
            Console.WriteLine();
        }
        static int CheckID(int id, int max, int[] ID)
        {
            for(int i = 0; i < max; i++)
            {
                if(ID[i] == id)
                {
                    return i;
                }
            }

            return 90;
        }

        public static void Main(string[] args)
        {
            int[] arrID = new int[3];
            int[] arrKor = new int[3];
            int[] arrMath = new int[3];
            int[] arrEng = new int[3];

            for(int i = 0; i < MAX; i++)
            {
                InputID(arrID, i);
                InputKor(arrKor, i);
                InputMath(arrMath, i);
                InputEng(arrEng, i);
                Console.WriteLine();
            }

            PrintID(MAX, arrID);

            while (true)
            {
                Console.Write("학생 아이디를 입력하세요. (단, 0은 나가기)");
                int check = int.Parse(Console.ReadLine());

                if (check == 0)
                    break;

                int temp = CheckID(check, MAX, arrID);

                if (temp != 90)
                {
                    Console.WriteLine("국어 점수 : {0}", arrKor[temp]);
                    Console.WriteLine("수학 점수 : {0}", arrMath[temp]);
                    Console.WriteLine("영어 점수 : {0}", arrEng[temp]);
                    Console.WriteLine("총점 : {0}", arrKor[temp] + arrMath[temp] + arrEng[temp]);
                    Console.WriteLine("평균 : {0}", (arrKor[temp] + arrMath[temp] + arrEng[temp]) / 3);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("학생 아이디가 존재하지 않습니다. 다시 입력해주세요.");
                    Console.WriteLine();
                }
            }
        }
    }
}
