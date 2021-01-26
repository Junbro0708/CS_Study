using System;

namespace _057_Check
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] grade = new int[5];

            for(int i = 0; i < grade.Length; i++)
            {
                Console.WriteLine("학생의 성적을 입력하세요.");
                grade[i] = int.Parse(Console.ReadLine());
            }

            int min = grade[0];
            int max = 0;

            for (int i = 0; i < grade.Length; i++)
            {
                if (min > grade[i])
                    min = grade[i];

                if (max < grade[i])
                    max = grade[i];
            }

            Console.WriteLine("최대값 : {0} 최소값 : {1}", max, min);
        }
    }
}
