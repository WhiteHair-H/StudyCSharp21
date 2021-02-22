using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstTestApp
{ 
    class Program
    {
        enum Season
        {
            Spring = 1000, 
            summer = 2000,
            Fall = 3000,
            Winter = 4000
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double PI = 3.141592;
            Console.WriteLine($"원주율의 값은 {PI}");
            //PI = 6.345;

            Season mySeason = Season.Winter; // error(Season)3;//Season.summer;
            Console.WriteLine($"지금 계절은 {mySeason}입니다");


            int a = 0;
            Console.WriteLine($"a는 {a}");
            int? b = null;
            Console.WriteLine($"b는 {b}");




        }
    }
}
