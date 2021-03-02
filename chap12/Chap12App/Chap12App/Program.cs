using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }*/


            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
