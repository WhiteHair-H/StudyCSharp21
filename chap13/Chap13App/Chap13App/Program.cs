using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13App
{

    delegate int Mydelgate(int a, int b);//대리자 대신 호출 , 호출할 메서드와 파라미터 타입/개수 일치해야함


    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Mydelgate Callback;

            Callback = new Mydelgate(calc.Plus);

            Console.WriteLine($"result = {Callback(3,7)}");

            Callback = new Mydelgate(calc.Minus);
            Console.WriteLine($"result = {Callback(3,7)}");


         }
    }
}
