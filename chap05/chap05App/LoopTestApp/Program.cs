using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int a = 10;
            while (a > 0)
            {
                Console.WriteLine($"숫자는 {a}");
                a -= 2;
                
            }
            Console.WriteLine("출력종료");

            a = 11;
            do
            {
                Console.WriteLine($"숫자 {a}");
                a++;
            } while (a < 10);*/


            Console.WriteLine("구구단 시작");
            for (int i = 2; i < 10; i++)
            {

                Console.WriteLine($"{i}단 시작");
                for (int z = 1; z < 10; z++)
                {
                    Console.Write($"{i} * {z} = {i * z}");
                    
                }
                Console.WriteLine($"\n{i}단 끝");

            }



        }
    }
}
