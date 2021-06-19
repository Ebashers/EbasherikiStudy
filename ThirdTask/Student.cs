using System;

namespace ThirdTask
{
    public class Student : Person
    {
        string faculty { get; set; } = "WF";
        int course { get; set; } = 1;
        int specialty { get; set; } = 121;
        int score { get; set; } = 60;


        public Student() {}

        public Student(string name) : base(name){}
        
        public Student(string name, string gender) : base(name, gender){}
        
        public Student(string name, string gender, int age)
            : base(name, gender, age){}

        public Student(string name, string gender, int age, string faculty)
            : base(name, gender, age)
        {
            this.faculty = faculty;
        }
        
        public Student(string name, string gender, int age, string faculty, int course)
            : base(name, gender, age)
        {
            this.faculty = faculty;
            this.course = course;
        }
        
        public Student(
            string name, string gender, int age, int weight, int height, string faculty, int course, int specialty)
            : base(name, gender, age)
        {
            this.faculty = faculty;
            this.course = course;
            this.specialty = specialty;
        }
        
        public Student(string name, string gender, int age, 
            int weight, int height, string faculty, int course, int specialty, int score)
            : base(name, gender, age)
        {
            this.faculty = faculty;
            this.course = course;
            this.specialty = specialty;
            this.score = score;
        }
        
        
        public void GetStudentInfo()
        {
            Console.WriteLine(
                $"\nName: {name} \nFaculty: {faculty} \nCourse: {course} \nSpecialty: {specialty} \nScore: {score}");
        }
        
        
        public override void GetInfo() 
        {
            GetStudentInfo();
            Console.WriteLine
                ($"Gender: {gender} \nAge: {age} ");
        }
    }
}