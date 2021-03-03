using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEventApp
{
    delegate void EventHandler(string message);

    class customNotifier // 객체가 대리자를 가져다 사용
    {
        public event EventHandler SometingHappened; // 객체의 속성 / SometingHappened - 대리자의 이벤트

        public void Dosomething(int number) // 객체의 기능
        {
            int temp = number % 10; // 46 % 10 = 3 % 3 == 0

            if (temp != 0 && temp % 3 == 0) // 3,6,9로 떨어지는 값
            {
                SometingHappened($"{number} : 짝! "); // 이벤트 사용 (로직없음)
            }
        }
    }

    class Program
    {
        // 이벤트가 발생했을 때  실행되는 메서드

        public static void MyHandler(string message) //값을 받아서 출력 / 메서드
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용");
            customNotifier notifier = new customNotifier();
            notifier.SometingHappened += new EventHandler(MyHandler); // 이벤트를 내가 만든 로직이 있는 메서드랑 연결

            for (int i = 0; i <= 100; i++)
            {
                notifier.Dosomething(i);
            }
        }
    }
}
