using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListApp
{
    class Program
    {

        // 실무에서 가장 많이 사용되는 컬렉션 1
        // 속도, 일반화 부분에서 가장 많이 사용
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6};
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }


            Console.WriteLine("Descending");

            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("값추가");

            list.Insert(3, 20);
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("값삭제");
            list.RemoveAt(4);
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("문자값");
            List<string> strList = new List<string> {"일", "이", "삼", "사", "오"};
            foreach (var item in strList)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
