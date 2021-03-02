using System;

namespace DelegateChainApp
{
    delegate void AllClac(int x, int y); // 대리자 선언

    class Program
    {

        static void Plus(int a, int b)
        {
            Console.WriteLine($"a + b = {a + b}");
        }
        static void Minus(int a, int b)
        {
            Console.WriteLine($"a - b = {a - b}");
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine($"a / b = {a / b}");
        }
        static void multiple(int a, int b)
        {
            Console.WriteLine($"a * b = {a * b}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Calculating!");
            AllClac allClac = Plus;
             allClac += Minus;
             allClac += Divide;
             allClac += multiple;

            allClac(10, 5);

            Console.WriteLine("곱셈 메서드 제거");
            allClac -= multiple;
            allClac(10, 5);
        }
    }
}
