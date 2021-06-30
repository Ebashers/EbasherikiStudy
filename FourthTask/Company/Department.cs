using System.Collections.Generic;

namespace FourthTask
{
    public class Department
    {
        public string DepartmentName { get; set; } = "departmentName";
        public Employee Chief { get; set; } = new();
        public List<Employee> Employees { get; set; } = new();
        
        
        public Department(string departmentName)
        {
            this.DepartmentName = departmentName;
        }
        
        public Department(string departmentName, Employee chief) : this(departmentName) 
        {
            this.Chief = chief;
        }
        
        public Department(string departmentName, Employee chief, List<Employee> employees) : this(departmentName, chief) 
        {
            this.Employees = employees;
        }
    }
}