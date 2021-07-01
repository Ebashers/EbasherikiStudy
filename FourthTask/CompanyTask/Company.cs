using System.Collections.Generic;

namespace FourthTask.CompanyTask
{
    public class Company
    {
        public string CompanyName { get; set; } = "companyName";
        public Employee Ceo { get; set; } = new();
        public List<Department> Departments { get; set; } = new();
        
        public Company(string companyName)
        {
            this.CompanyName = companyName;
        }
        
        public Company(string companyName, Employee ceo) : this(companyName) 
        {
            this.Ceo = ceo;
        }
        
        public Company(string companyName, Employee ceo, List<Department> departments) : this(companyName, ceo) 
        {
            this.Departments = departments;
        }
    }
}