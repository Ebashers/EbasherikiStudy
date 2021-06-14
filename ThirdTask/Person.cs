using System;

namespace ThirdTask
{
    public class Person
    {
        public string name;
        public string gender;
        public int age;


        public Person() 
        {
            name = "Unknown";
            gender = "male";
            age = 18;
        }

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