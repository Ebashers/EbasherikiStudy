namespace FourthTask.CompanyTask
{
    public class Employee
    {
        public string Name { get; set; } = "name";
        public string Surname { get; set; } = "surname";
        public int Salary { get; set; } = 0;
        
        public Employee(){}
            
        public Employee(string name)
        {
            this.Name = name;
        }
        
        public Employee(string name, string surname) : this(name) 
        {
            this.Surname = surname;
        }
        
        public Employee(string name, string surname, int salary) : this(name, surname) 
        {
            this.Salary = salary;
        }
        
    }
}