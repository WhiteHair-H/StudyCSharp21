using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("컬랙션 배열 사용 + 50 추가");

            ArrayList array = new ArrayList(new[] {80,74,81,90,34 });

            //array.RemoveAt(1);

            var loc =  array.IndexOf(81);
            array.Insert(loc, 50);

            foreach (var item in array)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine("90제거");
            array.RemoveAt(4);
            foreach (var item in array)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine("컬랙션 배열 사용 + sort 사용");
            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine($" {item}");
            }

           


        }
    }
}
