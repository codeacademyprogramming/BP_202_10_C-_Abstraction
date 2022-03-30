using System;

namespace _30032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Artur");
            dog.Age = 4;
            dog.MakeSound();
            Console.WriteLine(dog.GetInfo());

            Cat cat = new Cat();
            cat.Name = "Mestan";
            cat.MakeSound();

            Console.WriteLine(cat.GetInfo());

            Employee employee = new Employee("Hikmet")
            {
                Position = "Satici"
            };

            Student student = new Student("Firengiz")
            {
                GroupNo = "111"
            };

            employee.Introduce();
            student.Introduce();


            Ak47 ak47 = new Ak47();


            Console.WriteLine("\n=====================\n");
            Student std = new Student("Hikmet","111");
            Human human = std;
            human.Introduce();
            Console.WriteLine(human.GetInfo());

            Employee employee1 = new Employee("Tofiq");
            Human human1 = employee1;
            human1.Introduce();
            Console.WriteLine(human1.GetInfo());

            Ak47 silah = new Ak47();

            Gun gun = silah;
            IGun gun1 = silah;

            IFireable fireable = silah;
            fireable.Show();



        }
    }
}
