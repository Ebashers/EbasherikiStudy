using System;
using System.Collections.Generic;

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
                int maxSalary = employeesList[0].salary;
                foreach (var i in employeesList)
                {
                    if (maxSalary < i.salary)
                    {
                        maxSalary = i.salary;
                    }
                }
                Console.WriteLine("Max salary is:" + maxSalary);
            }
            
            void EgalitarianDepart()
            {
                foreach (var department in ebasheri.departments)
                {
                    Employee departChief = department.chief;
                    foreach (var employee in department.employees)
                    {
                        if (departChief.salary < employee.salary)
                        {
                            Console.WriteLine
                                ($"In department {department.departmentName} employee has bigger salary than chief");
                            break;
                        }
                    }
                }
            }
            
            GetMaxSalary();
            EgalitarianDepart();
            
        }
    }
}