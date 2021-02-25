using System;

namespace OverrideTestApp
{
    class ArmorSuite
    {

        //virtual 자식클래스에서 재정의
        public virtual void Initialize()
        {
            Console.WriteLine("ArmorSuite 초기화!");
        }



    }

    class IromMan : ArmorSuite
    {
        public override void Initialize()
        {
            //base.Initialize();
            Console.WriteLine("레이저 장착");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            //base.Initialize(); 부모의 일을 하지 않고 자식에서 재정의 후 선언 , 실무에서도 자주 사용함
            Console.WriteLine("ArmorSuite 개량화!!");
            Console.WriteLine("Double-Barrel 캐논 장착");
            Console.WriteLine("Micro-Rocket 런처 장착");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("Warmachine 생산");
            WarMachine machine = new WarMachine();
            machine.Initialize();


            Console.WriteLine("아이언맨 생산");
            IromMan irom = new IromMan();
            irom.Initialize();
        }
    }
}
