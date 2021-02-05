using System;

namespace _082_Class_base
{
    class Super
    {
        int num;
        protected string name;

        public Super(int num)
        {
            this.num = num;
        }

        public void PrintSuper()
        {
            Console.WriteLine("Super num : {0}", num);
        }
    }
    class Sub : Super
    {
        string name;

        public Sub(int num, string name):base(num)
        {
            this.name = name;
        }

        public void PrintSub()
        {
            base.name = "Super";
            base.PrintSuper();

            Console.WriteLine("Super name : {0}", base.name);
            Console.WriteLine("Sub name : {0}", this.name);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Sub sub = new Sub(25, "Junbro");
            sub.PrintSub();
        }
    }
}
