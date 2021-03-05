using System;
using System.Threading;

namespace Chap19App
{
    class Program
    {
        static void Dosomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Dosomething : {i}");
                Thread.Sleep(10); // 1/100초 동안 멈춤
            }
        }

        static void SomethingHappened()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"SomethingHappened : {i}");
                Thread.Sleep(10); // 1/100초 동안 멈춤
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("스레드 시작");

            Thread thread = new Thread(new ThreadStart(Dosomething));
            Thread thread1 = new Thread(SomethingHappened); // new를 굳이 안적어도됨


            Console.WriteLine("스레드 시작");
            thread.Start();
            thread1.Start();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"main thread : {i}");
                Thread.Sleep(10);
            }
            try
            {
                thread.Abort();
                Console.WriteLine("스레드 종료 대기...");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
            finally
            {
                thread.Join();
                thread1.Join();

                Console.WriteLine("프로세스 종료...");
            }

        }
    }
}
