using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using FourthTask.CompanyTask;
using FourthTask.BlogTask;



namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nFirst Part\n");
            
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
            
            int GetMaxSalary()
            {
                var maxSalary = employeesList.Select(e=>e.Salary).Max(); 
                return maxSalary;
            }
            
            List<Department> EgalitarianDepart()
            {
                var egalitarianDepart = ebasheri.Departments.Where(
                    d => d.Chief.Salary < d.Employees.Select(e => e.Salary).Max()).ToList();
                return egalitarianDepart;
            }
            
            Console.WriteLine("Max salary: " + GetMaxSalary());
            if (EgalitarianDepart().Count != 0)
            {
                foreach (var d in EgalitarianDepart())
                {
                    Console.WriteLine($"In {d.DepartmentName} department employee has bigger salary than chief");    
                }
            }
            else
            {
                Console.WriteLine("There is no department where employee has bigger salary than chief");
            }

            Console.WriteLine("List of employees:");
            foreach (var employee in employeesList)
            {
                Console.WriteLine(employee.Name);    
            }
            
            Console.WriteLine("--------------------------------------------------------------------\nSecond Part\n");
            
            Comment introComment1 = new Comment
                ("' Всем привет, с вами Элез '  Мне больше нравился ^_^ ", 159, 15);
            
            Comment introComment2 = new Comment
                ("6 лет назад... и тут рекомендация", 10, 1);
            
            Comment warfaceComment1 = new Comment
                ("Мне кажется,Элез бы отлично сыграл Джокера. Пугающе. Именно.", 228000000, 28);
            
            Comment warfaceComment2 = new Comment
                ("у меня мурашки по коже когда он разговаривает", 8, 0);

            Video warface = new Video("Warface: НАЧАТЬ С НУЛЯ?", "https://www.youtube.com/watch?v=jgELCkPJ4LQ",
                1791927, 30764, 5672,  new List<Comment>{warfaceComment1, warfaceComment2});
            Video intro = new Video("Intro для канала Элез", "https://www.youtube.com/watch?v=6vshj3lPUx0",
                4516796, 19809, 5020,  new List<Comment>{introComment1, introComment2});
            Blog eles = new Blog("Элез", new List<Video>{warface, intro});
            
            int GetViewsSum()
            {
                /*
                int viewsSum = 0;
                foreach (var video in eles.VideosList)
                {
                    viewsSum += video.Views;
                }
                */
                var viewsSum = (from video in eles.VideosList select video.Views).Sum();
                return viewsSum;
            }

            bool HasTopComment()
            {
                var topComment = (from videoList in eles.VideosList select 
                        (videoList.Likes, from comment in videoList.CommentsList select comment.Likes)).Any
                    (v => v.Likes < v.Item2.Max());
                return topComment;
            }

            IEnumerable<Video> MostDislikedVideos()
            {
                int mostDislikes = (from video in eles.VideosList select video.Dislikes).Max();
                var mostDislikesList = (from video in eles.VideosList select video).TakeWhile
                    (v => v.Dislikes == mostDislikes);
                return mostDislikesList;
            }

            Console.WriteLine("Sum of views: " + GetViewsSum());
            Console.WriteLine(HasTopComment()
                ? "There is a comment that got more likes than a video"
                : "There is NO comment that got more likes than a video");
            Console.WriteLine("Most disliked videos: ");
            foreach (var video in MostDislikedVideos())
            {
                Console.WriteLine($"'{video.VideoName}' has {video.Dislikes} dislikes");
            }
        }
    }
}