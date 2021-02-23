using System;

namespace _089_interface
{
    interface IAA
    {
        //public int a;
        //private void Print();

        int A { get; set; }
        void IAAPrint();
    }
    interface IBB
    {
        void IBBPrint();
    }

    class Super
    {
        protected int num;

        public virtual void Print()
        {
            Console.WriteLine("====================================");
        }
    }

    class AA : IAA
    {
        public int A { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void IAAPrint() // 무조건 재정의 해줘야함
        {
            throw new NotImplementedException();
        }
    }

    class BB : IAA, IBB
    {
        public int A { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void IAAPrint()
        {
            throw new NotImplementedException();
        }

        public void IBBPrint()
        {
            throw new NotImplementedException();
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
