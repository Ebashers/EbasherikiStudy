using System;

namespace ThirdTask
{
    public class Person
    {
        public string name { get; set; } = "Unknown";
        public string gender { get; set; } = "male";
        public int age { get; set; } = 18;


        public Person() {}

        public Person(string name)
        {
            this.name = name;
        }
        
        public Person(string name, string gender) : this(name) 
        {
            this.gender = gender;
        }
        
        public Person(string name, string gender, int age) : this(name, gender) 
        {
            this.age = age;
        }
        

        public virtual void GetInfo()
        {
            Console.WriteLine
                ($"\nName: {name} \nGender: {gender} \nAge: {age} ");
        }
    }
}