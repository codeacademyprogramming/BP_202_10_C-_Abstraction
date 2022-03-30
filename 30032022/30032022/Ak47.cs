using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal class Ak47 :Gun, IGun,IFireable
    {
        private int _magazineCapacity;
        public int MagazineCapacity { get => _magazineCapacity; set { if (value > 0) _magazineCapacity = value; } }
        public int CurrentMagazine { get; set; }
        public string Country { get; set; }

        public void Fire()
        {
            Console.WriteLine("Disin Disin");
            if (CurrentMagazine > 1)
                CurrentMagazine -= 2;
            else
                Console.WriteLine("Gulle bitib");
        }

       
    }
}
