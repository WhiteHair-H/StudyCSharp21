using System;
using System.Collections.Generic;
using System.Text;

namespace NewInHeritTestApp
{
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name} : 냥냥");
        }
    }
}
