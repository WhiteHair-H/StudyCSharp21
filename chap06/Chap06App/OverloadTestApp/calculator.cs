using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadTestApp
{
    class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기");

            int x = calculator.Plus(3, 4);
            Console.WriteLine($"3 + 4 = {x}");

            float y = calculator.Plus(3.14f, 5.6f);
            Console.WriteLine($"3.14f + 5.6f = {y}");

            Console.WriteLine($"3.14 + 5.6 = {calculator.Plus(3.14, 5.6)}");


            Console.WriteLine($"3.14 + 5.6 = {calculator.Plus(3.14, "5")}");

            int z = calculator.Plus(7, 8, 9);
            Console.WriteLine($"7 + 8 + 9 = {z}");


            int total = 0;
            total = sum(1, 2 , 4 , 5 , 6,7,8,1000);

            Console.WriteLine($"합계는 {total}");

            int[] arrs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"10까지의 합은 {sum(arrs)}");


        }

        
        private static int sum(params int[] args)
        {
            int result = 0;

            foreach (var arg in args)
            {
                result += arg;
            }
            return result;

        }

        private static int Plus(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }

        private static double Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            double result = 0;
            return result;
        }

        private static double Plus(double v1, double v2)
        {
            double result = v1 + v2;
            return result;
        }

        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }

        


    }
}
