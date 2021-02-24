using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap07
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체 사용");

            /*Cat cat1 = new Cat("고양이", "흰색"); // 객체1
            *//*cat1.Name = "고양이";
            cat1.color = "흰색";*//*
            cat1.Meow();

            Cat kitty = new Cat(); // 객체2
            kitty.Name = "헬로키티";
            kitty.color = "하얀색";
            kitty.Meow();

            Cat nero = new Cat(); // 객체3
            nero.Name = "네로";
            nero.color = "검은색";
            nero.Meow();
*/

            Cat yom = new Cat("요미", "흰색", "암컷");
            yom.Meow();


        }
    }



    class Cat




    {   public Cat() { }

        //~Cat() { } //  
        
        public Cat(string Name)
        {

        }


       public Cat(string Name, string Color) : this(Name)// 객체 생성자는 항상 사용하기 때문에 숨어있음
        {
            this.Color = Color;

        }
        public Cat(string Name, string Color, string Gender) : this(Name, Color)
        {

            this.Gender = Gender;

        }



        // 특성 속성 변수
        public string Name;
        public string Color;
        public string Gender;


        // 행위 기능 메소드
        public void Meow()
        {
            Console.WriteLine($"{Name}, {Color} : 야옹 ");
        }
    }
}
