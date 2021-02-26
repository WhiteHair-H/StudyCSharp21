using System;

namespace _2DArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int z = 0; z < arr.GetLength(1); z++)
                {
                    Console.Write($"[{i}, {z}] : {arr[i, z]}\t");
                }
                Console.WriteLine("");
            }


            

        }
    }
}
