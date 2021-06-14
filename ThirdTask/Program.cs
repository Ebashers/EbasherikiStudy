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
            chel.GetInfo();
            rolik.GetInfo();
            ruslan.GetInfo();
            ruslan.GetStudentInfo();
            mikrochel.GetInfo();
            zhmyh.GetInfo();
            
        }
    }
}