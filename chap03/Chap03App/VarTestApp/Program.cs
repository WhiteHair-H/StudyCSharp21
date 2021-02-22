using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 100; // 지역변수안에서 사용가능함
            Console.WriteLine($"정수값은 {i} 입니다.");
        }
    } 
}
