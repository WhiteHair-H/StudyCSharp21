using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap04App
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = 37656234;
            if (values % 2 == 0)
            {
                Console.WriteLine("짝수입니다");

            }
            else
            {
                Console.WriteLine("홀수입니다");
            }

            if (values % 3 == 0)
            {
                Console.WriteLine("3의배수 입니다");

            }
            else
            {
                Console.WriteLine("3의배수가 아닙니다");
            }
            if (values % 7 == 0)
            {
                Console.WriteLine("7의배수 입니다");

            }
            else
            {
                Console.WriteLine("7의배수가 아닙니다");
            }

        }
    }
}
