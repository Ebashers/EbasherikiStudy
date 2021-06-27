using System;

namespace ThirdTask
{
    public class Person
    {
        public string Name { get; set; } = "Unknown";
        public string Gender { get; set; } = "male";
        public int Age { get; set; } = 18;


        public Person() {}

        public Person(string name)
        {
            this.Name = name;
        }
        
        public Person(string name, string gender) : this(name) 
        {
            this.Gender = gender;
        }
        
        public Person(string name, string gender, int age) : this(name, gender) 
        {
            this.Age = age;
        }
        

        public virtual string GetInfo()
        { 
            return ($"\nName: {Name} \nGender: {Gender} \nAge: {Age} ");
        }
    }
}