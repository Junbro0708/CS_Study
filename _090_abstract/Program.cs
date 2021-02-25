using System;

namespace _090_abstract
{
    abstract class AbstractAA
    {
        protected int num;

        public AbstractAA(int num)
        {
            this.num = num;
        }

        public abstract void abstractPrint();

        public virtual void virtualPrint()
        {
            Console.WriteLine("abstract virtual void virtualPrint()");
        }

        public void Print()
        {
            Console.WriteLine("abstractAA Print()");
        }
    }

    class AA: AbstractAA
    {
        public AA(int num) : base(num)
        {
            Console.WriteLine("num : {0}", num);
        }

        public override void abstractPrint()
        {
            
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
