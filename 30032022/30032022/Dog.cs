using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal class Dog:Animal
    {
        public Dog(string name)
        {
            this.Name = name;
        }


        public override void MakeSound()
        {
            Console.WriteLine("hav hav");
        }

        public override string GetInfo()
        {
            return $"Name: {this.Name} - Age: {this.Age}";
        }
    }
}
