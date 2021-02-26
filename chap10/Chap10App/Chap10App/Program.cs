using System;

namespace Chap10App
{
    class Test
    { }


    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 80, 74, 90, 65, 10 }; /*new int[5];
            scores[0] = 5;
            scores[1] = 10;
            scores[2] = 80;
            scores[3] = 74;
            scores[4] = 90;*/
            for (var i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"{i}의 점수는 {scores[i]}");
            }

            Array.Resize ( ref scores, 6 );
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"{i}의 점수는 {scores[i]}");
            }

            int idx = Array.IndexOf(scores, 81);
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"{i}의 점수는 {scores[i]}");
            }



            /*Console.WriteLine("힘든 방법");

            Console.WriteLine($"점수는 {scores[0]}");
            Console.WriteLine($"점수는 {scores[1]}");
            Console.WriteLine($"점수는 {scores[2]}");
            Console.WriteLine($"점수는 {scores[3]}");
            Console.WriteLine($"점수는 {scores[4]}\n");

            Console.WriteLine($"Type of array : {scores.GetType()}");
            Console.WriteLine($"Base Type of array : {scores.GetType().BaseType}");



            Console.WriteLine("foreach 방법");
            foreach (var score in scores)
            {
                Console.WriteLine($"점수는 {score}");
            }


            Console.WriteLine("\nfor 방법");
            for (var i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"점수는 {scores[i]}");
            }*/

            /*Console.WriteLine("\n오름차순 정렬");
            Array.Sort(scores);
            for (var i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"점수는 {scores[i]}");
            }

            Console.WriteLine("\n내림차순 정렬");
            Array.Reverse(scores);
            for (var i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"점수는 {scores[i]}");
            }

            int idx = Array.IndexOf(scores,74);
            Console.WriteLine($"{idx}");

            int idx1 = Array.IndexOf(scores, 100);
            Console.WriteLine($"{idx1}");

            Array.Clear(scores, 3, 2);
            for (var i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"{scores[i]}");
            }*/



        }

    }
}
