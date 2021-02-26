using System;
using System.Collections.Generic;
using System.Text;

namespace NewInHeritTestApp
{
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine($"{this.Name} : 날다!");
        }
    }
}
