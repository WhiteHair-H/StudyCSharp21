using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        // 실무에서 많이 쓰는 컬렉션 2

        static void Main(string[] args)
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" },
                {5, "Five" }
            };
            /*pairs[1] = "one";
            pairs[2] = "Two";
            pairs[3] = "Three";
            pairs[4] = "Four";
            pairs[5] = "Five";*/


            foreach (var item in pairs)
            {
                Console.WriteLine(item);
            }

            //순서대로 입력됨 <-> hashtable은 실행할때마다 바뀌어서 나옴
            Dictionary<string, string> pairs2 = new Dictionary<string, string>();
            pairs2["일"] = "one";
            pairs2["이"] = "Two";
            pairs2["삼"] = "Three";
            pairs2["사"] = "Four";
            pairs2["오"] = "Five";


            foreach (var item in pairs2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
