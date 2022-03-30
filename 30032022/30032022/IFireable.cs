using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal interface IFireable
    {
        void Fire();

        public void Show()
        {
            Console.WriteLine("Show me");
        }

    }
}
