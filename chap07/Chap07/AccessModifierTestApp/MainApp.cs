using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTestApp
{
    public class Boiler
    {
        internal int temp = 5 ; // 물온도 //public, protected , private, internal (빈도가 별로)

        public void SetTemp(int temp) // void만 넣었을 경우 private 값으로 지정됨
        {
            if (temp < 30 || temp > 60)
            {Console.WriteLine("물의 온도가 일정온도를 벗어났습니다. 다시 셋팅해주세요");
                return;
                this.temp = temp;            
            }
            else
            {
                this.temp = temp;
            }
            }

        public int GetTemp()
        {
            return this.temp;
        }

        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 켭니다.");
        }
        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 끕니다.");
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            var currTemp = kitturami.GetTemp();
            Console.WriteLine($"현재 온도는  {currTemp}도 입니다.");
            kitturami.SetTemp(44);
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);
            






            kitturami.temp = 45;
            kitturami.TurnOnBoiler();
            Console.WriteLine($"현재 온도는 {kitturami.temp}");
            kitturami.temp = 70;
            kitturami.TurnOffBoiler();
        }
    }
}
