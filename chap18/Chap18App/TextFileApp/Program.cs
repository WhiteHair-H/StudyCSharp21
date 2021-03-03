using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\GitRepository\StudyCSharp21\SampleDir\subFolder";

            StreamWriter sw = null;


            try
            {
                sw = new StreamWriter(new FileStream(filepath, FileMode.Create));
                sw.WriteLine(int.MaxValue);
                sw.WriteLine("Hello , World");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"파일쓰기 예외발생: {ex.Message}");
            }

            finally
            {

            }
            sw.Close();

        }
    }
}
