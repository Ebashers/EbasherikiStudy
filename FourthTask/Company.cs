using System.Collections.Generic;

namespace FourthTask
{
    public class Company
    {
        public string companyName { get; set; } = "companyName";
        public Employee ceo { get; set; } = new();
        public List<Department> departments { get; set; } = new();
        
        public Company(string companyName)
        {
            this.companyName = companyName;
        }
        
        public Company(string companyName, Employee ceo) : this(companyName) 
        {
            this.ceo = ceo;
        }
        
        public Company(string companyName, Employee ceo, List<Department> departments) : this(companyName, ceo) 
        {
            this.departments = departments;
        }
    }
}