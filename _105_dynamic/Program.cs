using System;
using Microsoft.CSharp;

namespace _105_dynamic
{
    class MainClass
    {
        static T AddArray<T>(T[] arrDates)
        {
            //T temp = 0; int형을 바로 T에 넣으면 오류가 발생함 / null일 수도 있으니까
            //object aaa = 0; 사용은 할 수 있는데 박싱 언박싱이 발생해서 프로그램의 데이터가 커질 수 있음
            dynamic temp = default(T); // 좋은 대안 dynamic
            for(int i = 0; i < arrDates.Length; i++)
            {
                temp += arrDates[i];
            }
            return temp;
        }

        static T SumArray<T>(T[] arrDates) // 다른 방법
        {
            T temp = default(T);
            for (int i = 0; i < arrDates.Length; i++)
            {
                temp += (dynamic)arrDates[i];
            }
            return temp;
        }

        static void PrintArray<T>(T[] arrDatas)
        {
            foreach(var data in arrDatas)
            {
                Console.WriteLine("data : {0}", data);
            }
        }

        public static void Main(string[] args)
        {
            int[] arrNums = { 1, 2, 3, 4, 5 };

            Console.WriteLine("AddArray : {0}", AddArray(arrNums));
            PrintArray(arrNums);
        }
    }
}
