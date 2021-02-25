using System;

namespace exam
{
    class Mammal
    {
        public void Nurse()
        {

        }
    }

    class Dog : Mammal
    {
        public void Barl()
        {

        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Nurse();

            Dog dog = new Dog();
            
        }
    }
}
