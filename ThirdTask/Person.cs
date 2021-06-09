using System;

namespace ThirdTask
{
    public class Person
    {
        public string name;
        public string gender;
        public int age;
        public int weight;
        public int height;

        public Person() 
        {
            name = "Unknown";
            gender = "male";
            age = 18;
            weight = 70;
            height = 180;
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
        
        public Person(string name, string gender, int age, int weight) : this(name, gender, age) 
        {
            this.weight = weight;
        }
        
        public Person(string name, string gender, int age, int weight, int height) : this(name, gender, age, weight) 
        {
            this.height = height;
        }
        

        public virtual void GetInfo()
        {
            Console.WriteLine
                ($"\nName: {name} \nGender: {gender} \nAge: {age} \nWeight: {weight} kg\nHeight: {height} cm");
        }
    }
}