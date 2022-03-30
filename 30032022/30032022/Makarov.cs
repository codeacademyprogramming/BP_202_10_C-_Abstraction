using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal class Makarov : IGun,IFireable
    {
        public int MagazineCapacity { get; set; }
        public int CurrentMagazine { get ; set; }
        public string Country { get; set ; }

        public void Fire()
        {
            Console.WriteLine("Disin");
            if (CurrentMagazine > 0)
                CurrentMagazine--;
            else
                Console.WriteLine("Gulle bitdi");
        }
    }
}
