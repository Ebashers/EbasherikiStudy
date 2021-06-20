using System;

namespace FourthTask
{
    public class Employee
    {
        public string name { get; set; } = "name";
        public string surname { get; set; } = "surname";
        public int salary { get; set; } = 0;
        
        public Employee(){}
            
        public Employee(string name)
        {
            this.name = name;
        }
        
        public Employee(string name, string surname) : this(name) 
        {
            this.surname = surname;
        }
        
        public Employee(string name, string surname, int salary) : this(name, surname) 
        {
            this.salary = salary;
        }
        
    }
}