using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTestApp
{

    class Parent // 부모 순위 base > super
    {
        protected string Name; // 특성은 이름만 있음 , public을 사용할 경우 어디서든 사용가능하기에 protected를 사용함

        public Parent(string Name) // 생성자
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Parent() 생성자");
        }

        ~Parent()
        {
            Console.WriteLine($"{this.Name}.Parent() 소멸자");

        }

        public void ParentMethod() // 1개의 메소드(행위)
        {
            // ...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }

    }

     class Child : Parent // 부모로부터 상속 받을 자식 생성 부모가 실행되고 자식이 실행됨
    {

        public string Color; // 색상


        public Child(string Name) : base(Name) // base를 사용할 경우 부모를 먼저 실행하고 자식이 실행됨
        {
            Console.WriteLine($"{this.Name}.child() 생성자"); // protected를 통해 사용가능하게 만듬
        }

        ~Child()
        {
            Console.WriteLine($"{this.Name}.child() 소멸자");

        }

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.childMethod() 실행");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod(); //부모클래스 메서드 실행


            Child c = new Child("자식");
            c.Color = "황색";
            c.ParentMethod(); // 자식 클래스가 부모의 메서드를 실행
            c.ChildMethod(); // 자식클래스 메서드 실행
        }
    }
}
