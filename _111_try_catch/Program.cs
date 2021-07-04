using System;

namespace _111_try_catch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int inputNum = 0;
            bool isCorrect = false;

            while (!isCorrect)
            {
                string readStr = Console.ReadLine();

                try
                {
                    inputNum = int.Parse(readStr);
                    isCorrect = true;
                }catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("입력문자 : " + readStr + "은 정수가 아닙니다. 정수를 입력하세요.");
                }
            }

            Console.WriteLine("InputNum : " + inputNum);
        }
    }
}
