﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NewInHeritTestApp
{
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name} : 멍멍!");
        }

        public void HowOld()
        {
            Console.WriteLine($"{this.Name}의 나이는 {this.Age}");
        }

    }
}