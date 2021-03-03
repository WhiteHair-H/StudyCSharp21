using System;
using System.Text;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello");

            sb.Append("My name is Hugo.\n");
            sb.Append("I'm 27 years old\n");
            sb.Append("Book price is 30000 won.");
            sb.Insert(6, "new ");
            sb.Replace("book", "시계");




            Console.WriteLine(sb);
        }
    }
}
