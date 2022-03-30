using System;
using System.Collections.Generic;
using System.Text;

namespace _30032022
{
    internal class Student:Human
    {
        public Student(string name) : base(name)
        {
        }
        public Student(string name,string groupNo):base(name)  
        {
            this.GroupNo = groupNo;
        }
        public string GroupNo { get; set; }
        public override void Introduce()
        {
            Console.WriteLine($"Men telebeyem,{GroupNo} nomreli qrupda oxuyuram");
        }

        public override string GetInfo()
        {
            return $"Name: {Name} - GroupNo: {GroupNo}";
        }

    }
}
