using System.Collections.Generic;

namespace FourthTask
{
    public class Department
    {
        public string departmentName { get; set; } = "departmentName";
        public Employee chief { get; set; } = new();
        public List<Employee> employees { get; set; } = new();
        
        
        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }
        
        public Department(string departmentName, Employee chief) : this(departmentName) 
        {
            this.chief = chief;
        }
        
        public Department(string departmentName, Employee chief, List<Employee> employees) : this(departmentName, chief) 
        {
            this.employees = employees;
        }
    }
}