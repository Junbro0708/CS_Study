using System;

namespace _092_Property2
{
    class AA
    {
        private int num;
        private string name;

        public int NUM { get; set; }
        public string NAME { get; set; } = "NoNAME";
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            AA aa = new AA();
            Console.WriteLine("aa.NUM  : " + aa.NUM);
            Console.WriteLine("aa.NAME : " + aa.NAME);

            aa.NUM = 100;
            Console.WriteLine("aa.NUM  : " + aa.NUM);

            aa.NAME = "JUNBRO";
            Console.WriteLine("aa.NAME : " + aa.NAME);
        }
    }
}
