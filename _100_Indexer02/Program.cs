using System;
using System.Collections;

namespace _100_Indexer02
{
    class AA
    {
        ArrayList arrList = new ArrayList();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < arrList.Count)
                    return (string)arrList[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < arrList.Count)
                    arrList[index] = value;
                else if (index == arrList.Count)
                    arrList.Add(value);
            }
        }

        public int count
        {
            get { return arrList.Count; }
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            AA aa = new AA();

            for(int i = 0; i < 10; i++)
            {
                aa[i] = string.Format("{0}", i);
            }

            aa[0] = "Hello";
            aa[1] = "World";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("data : {0}", aa[i]);
            }
        }
    }
}
