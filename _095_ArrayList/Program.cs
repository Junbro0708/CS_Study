using System;
using System.Collections;

namespace _095_ArrayList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add("Hello");
            arrList.Add(10f);

            for(int i = 0; i < 10; i++)
            {
                arrList.Add(i);
            }

            foreach(object data in arrList)
            {
                Console.WriteLine("arrList data : " + data);
            }

            Console.WriteLine("배열 데이터로 초기화");
            int[] array = { 100, 200, 300 };
            ArrayList array1 = new ArrayList(array);

            foreach(object data in array1)
            {
                Console.WriteLine("array1 data : " + data);
            }
        }
    }
}
