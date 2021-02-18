using System;

namespace _085_class_has_a
{
    class AA
    {
        private int num;

        public void SetNum(int num)
        {
            this.num = num;
        }

        public void Print()
        {
            Console.WriteLine("Num : " + num);
        }
    }

    class BB
    {
        AA[] aa;

        public BB()
        {
            aa = new AA[5];
        }

        public void SetNum(int index, int num)
        {
            if(index < aa.Length)
            {
                aa[index] = new AA();
                aa[index].SetNum(num);
            }
        }

        public void Print()
        {
            for(int i = 0; i < aa.Length; i++)
            {
                if(aa[i] != null)
                {
                    aa[i].Print();
                }
            }
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            BB bb = new BB();
            bb.SetNum(0, 0);
            bb.SetNum(1, 100);
            bb.SetNum(2, 200);
            bb.SetNum(3, 300);
            bb.Print();
        }
    }
}
