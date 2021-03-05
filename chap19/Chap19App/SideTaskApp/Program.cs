﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SideTaskApp
{
    class SideTask
    {
        int Count { get; set; }


        public SideTask(int count)
        {
            this.Count = count;
        }

        public void CountDown()
        {
            try
            {
                while (Count > 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {Count} 남음");
                    Count--;
                    Thread.Sleep(10);
                }
                Console.WriteLine($"Count : {Count}");
            }

            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"스레드 임의종료 예외발생 : {ex.Message}");
               // Thread.ResetAbort();
            }

            catch (Exception ex)
            {

                Console.WriteLine($"스레드 예외발생 : {ex.Message}");
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.CountDown);
            th.IsBackground = false; //이 스레드가 종료되기 전까지는 모든 프로세스가 끝나지않음
            //True인 경우, 백그라운드 스레드가 돌옥있는 상태에도 메인스레가 끝나면 백그라운드 스레드도 같이 종료
            SideTask task1 = new SideTask(100);
            Thread th2 = new Thread(task1.CountDown); // 기본값 isBackground false

            Console.WriteLine("스레드 시작"); // 카운트다운 중간에 표시
            th.Start();
            th2.Start();

            Thread.Sleep(100); // 5초

            Console.WriteLine("인터럽트");
            th2.Interrupt();
            //Console.WriteLine("임의 종료");
            /*th.Abort();*/


            Console.WriteLine("종료대기");
            th.Join();
            th2.Join();

            Console.WriteLine("스레드 종료");




        }
    }
}
