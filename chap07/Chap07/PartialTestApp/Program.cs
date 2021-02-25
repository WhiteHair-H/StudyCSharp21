using System;

namespace PartialTestApp
{

    partial class MyClass
    {
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
        public void Method4()
        {
            Console.WriteLine("Method4");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass _Class = new MyClass();
            _Class.Method1();
            _Class.Method2();
            _Class.Method3();
            _Class.Method4();
        }
    }
}
