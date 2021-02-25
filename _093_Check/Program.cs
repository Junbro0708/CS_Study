using System;

namespace _093_Check
{
    class CStudent
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID { get { return id; } }
        public int KOR { get { return kor; } }
        public int MATH { get { return math; } }
        public int ENG { get { return eng; } }

        public CStudent()
        {
            id = 0;
            kor = 0;
            math = 0;
            eng = 0;
        }

        public void InputID()
        {
            Console.WriteLine("학생 ID를 입력하세요.");
            this.id = int.Parse(Console.ReadLine());
        }

        public void InputKor()
        {
            Console.WriteLine("국어 점수를 입력하세요.");
            this.kor = int.Parse(Console.ReadLine());
        }

        public void InputMath()
        {
            Console.WriteLine("수학 점수를 입력하세요.");
            this.math = int.Parse(Console.ReadLine());
        }

        public void InputEng()
        {
            Console.WriteLine("영어 점수를 입력하세요.");
            this.eng = int.Parse(Console.ReadLine());
        }

        public void PrintID()
        {
            Console.WriteLine("학생 ID : " + this.id);
        }

        public int GetTotal()
        {
            return kor + math + eng;
        }
    }
    class MainClass
    {
        static void PrintID(CStudent[] arrStudents)
        {
            foreach(CStudent data in arrStudents)
            {
                data.PrintID();
            }
        }

        static int CheckID(int id, CStudent[] arrStudents)
        {
            for(int i = 0; i < arrStudents.Length; i++)
            {
                if(id == arrStudents[i].ID)
                {
                    return i;
                }
            }

            return -1;
        }
        public static void Main(string[] args)
        {
            const int MAX = 3;
            int inputSel = 0;
            int selID = -1;

            CStudent[] arrStudents = new CStudent[MAX];

            for(int i = 0; i < MAX; i++)
            {
                arrStudents[i] = new CStudent();
                arrStudents[i].InputID();
                arrStudents[i].InputKor();
                arrStudents[i].InputMath();
                arrStudents[i].InputEng();

                Console.WriteLine();
            }

            Console.Clear();

            while (true)
            {
                PrintID(arrStudents);
                Console.Write("학생 아이디를 입력하세요. (단, 나가기는 0 입력)");
                inputSel = int.Parse(Console.ReadLine());

                if (inputSel == 0)
                    break;

                selID = CheckID(inputSel, arrStudents);

                if(selID >= 0)
                {
                    Console.WriteLine("국어 점수 : " + arrStudents[selID].KOR);
                    Console.WriteLine("수학 점수 : " + arrStudents[selID].MATH);
                    Console.WriteLine("영어 점수 : " + arrStudents[selID].ENG);

                    int total = arrStudents[selID].GetTotal();

                    Console.WriteLine("총점 : " + total);
                    Console.WriteLine("평균 : " + total/MAX);

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("학생 아이디가 없습니다.");
                }
            }
        }
    }
}
