using System;
using System.Collections;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTable 사용");
            Hashtable ht = new Hashtable();
            ht["book"] = "책"; // ht[키] = "값"
            ht["cook"] = "요리사";
            ht["tweet"] = "지저귀다";

            Console.WriteLine( ht["book"]);
            Console.WriteLine(ht["cook"]);
            Console.WriteLine( ht["tweet"]);
            
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
