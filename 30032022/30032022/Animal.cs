using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public abstract void  MakeSound();
        public virtual string GetInfo()
        {
            return $"Name: {this.Name}";
        }
    }
}
