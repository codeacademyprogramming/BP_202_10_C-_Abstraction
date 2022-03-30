using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal interface IGun
    {
        int MagazineCapacity { get; set; }
        int CurrentMagazine { get; set; }
        string Country { get; set; }
    }
}
