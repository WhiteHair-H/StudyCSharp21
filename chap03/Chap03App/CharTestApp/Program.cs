using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = '\t', ch2 = 'T', ch3 = '\n', ch4 = 'o';
            Console.WriteLine($"{ch1}, {ch2}, {ch3}, {ch4}");

            char ch5 = '\\';


            char ch = '\u2023';
            Console.WriteLine(ch);

            //문자열
            string str1 = "\n Hello, \n World!";
            Console.WriteLine($"{str1}");

            Boolean isNumeric = false;
            if (isNumeric)
            {
                Console.WriteLine("참입니다");
            }

            else
            {
                Console.WriteLine("거짓이얌");
            }


            Console.WriteLine(isNumeric);

            
        }
    }
}
