using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal abstract class Human
    {
        public Human(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract void Introduce();

        public  virtual string GetInfo()
        {
            return $"Name: {Name}";
        }
    }
}
