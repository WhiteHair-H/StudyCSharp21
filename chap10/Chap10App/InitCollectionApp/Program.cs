using System;
using System.Collections;

namespace InitCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            foreach (var item in list)
            {
                Console.WriteLine($"Arraylist : {item}");
            }

            Stack stack = new Stack(arr);
            foreach (var item in stack)
            {
                Console.WriteLine($"stack : {item}");
            }

            ArrayList list2 = new ArrayList() { 10, 20, 30, 40 };
            foreach (var item in list2)
            {
                Console.WriteLine($"Arraylist2 : {item}");
            }

        }
    }
}
