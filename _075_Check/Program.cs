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
        }
        static int CheckID(int id, int max, int[] ID)
        {
            if (ID.Contains(id))
                return id;
            else
                return 1;
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
                
            }
        }
    }
}
