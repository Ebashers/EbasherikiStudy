using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using FourthTask.Blog;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kola = new Employee("Kola", "Arharov", 1000);
            Employee victor = new Employee("Victor", "Savinov", 300);
            Employee fox = new Employee("Fox", "Sleepy", 300);
            Employee pavel = new Employee("Pavel", "Kuzennyi", 500);
            Employee zefir = new Employee("Zefir", "Lover", 100);
            Employee kate = new Employee("Kate", "Filonenko", 100);
            Employee sonya = new Employee("Sonya", "Len", 100);
            Department coders = new Department("Coders", victor, new List<Employee>{pavel, zefir});
            Department designers = new Department("Designers", fox, new List<Employee>{kate, sonya});
            Company ebasheri = new Company("Ebasheri", kola, new List<Department>{coders, designers});
            
            List<Employee> employeesList = new List<Employee> {kola, victor, fox, pavel, zefir, kate, sonya};
            
            void GetMaxSalary()
            {
                int maxSalary = employeesList[0].Salary;
                foreach (var i in employeesList)
                {
                    if (maxSalary < i.Salary)
                    {
                        maxSalary = i.Salary;
                    }
                }
                Console.WriteLine("Max salary is:" + maxSalary);
            }
            
            void EgalitarianDepart()
            {
                foreach (var department in ebasheri.Departments)
                {
                    Employee departChief = department.Chief;
                    foreach (var employee in department.Employees)
                    {
                        if (departChief.Salary < employee.Salary)
                        {
                            Console.WriteLine
                                ($"In department {department.DepartmentName} employee has bigger salary than chief");
                            break;
                        }
                    }
                }
            }
            
            GetMaxSalary();
            EgalitarianDepart();
            Console.WriteLine("List of employees:");
            foreach (var employee in employeesList)
            {
                Console.WriteLine(employee.Name);    
            }
            
            Console.WriteLine("--------------------------------------------------------------------\nSecond Part\n");
            
            
            
            Comment kola = new Employee("Kola", "Arharov", 1000);
            Comment victor = new Employee("Victor", "Savinov", 300);
            Comment fox = new Employee("Fox", "Sleepy", 300);
            Comment pavel = new Employee("Pavel", "Kuzennyi", 500);
            Comment zefir = new Employee("Zefir", "Lover", 100);
            Comment kate = new Employee("Kate", "Filonenko", 100);
            Comment sonya = new Employee("Sonya", "Len", 100);
            Video coders = new Department("Coders", victor, new List<Employee>{pavel, zefir});
            Video intro = new Video("Intro для канала Элез", "https://www.youtube.com/watch?v=6vshj3lPUx0",
                4516796, 19809, 5020,  new List<Comment>{kate, sonya});
            Blog elez = new Blog("Элез", new List<Video>(,));
            
        }
    }
}