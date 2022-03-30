using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal class Employee:Human
    {
        public Employee(string name):base(name)
        {

        }
        public string Position { get; set; }
        public override void Introduce()
        {
            Console.WriteLine($"Men iscilyem, {Position} vezifede calisiram");
        }
    }

   
}
