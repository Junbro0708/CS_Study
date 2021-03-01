using System;
using System.Collections;

namespace _098_HashTable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("pos", 10);
            hashtable.Add("name", "Jack");
            hashtable["weight"] = 10.8f;

            foreach(object key in hashtable.Keys)
            {
                Console.WriteLine("key : {0} value : {1}", key, hashtable[key]);
            }

            Console.WriteLine();

            Hashtable hashtable1 = new Hashtable()
            {
                ["pos"] = 10,
                ["name"] = "Jack",
                ["weight"] = 10.8f
            };
        }
    }
}
