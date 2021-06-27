using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Person chel = new Person();
            Person rolik = new Person("Rolik", "male", 69);
            Student mikrochel = new Student();
            Student zhmyh = new Student("Igor");
            Student ruslan = new Student(
                "Ruslan", "male", 14, 120, 180, "FICT", 3, 122, 100);
            Console.WriteLine(chel.GetInfo());
            Console.WriteLine(rolik.GetInfo());
            Console.WriteLine(ruslan.GetInfo());
            Console.WriteLine(ruslan.GetStudentInfo());
            Console.WriteLine(mikrochel.GetInfo());
            Console.WriteLine(zhmyh.GetInfo());

        }
    }
}