using System;

namespace ThirdTask
{
    public class Student : Person
    {
        string Faculty { get; set; } = "WF";
        int Course { get; set; } = 1;
        int Specialty { get; set; } = 121;
        int Score { get; set; } = 60;


        public Student() {}

        public Student(string name) : base(name){}
        
        public Student(string name, string gender) : base(name, gender){}
        
        public Student(string name, string gender, int age)
            : base(name, gender, age){}

        public Student(string name, string gender, int age, string faculty)
            : base(name, gender, age)
        {
            this.Faculty = faculty;
        }
        
        public Student(string name, string gender, int age, string faculty, int course)
            : base(name, gender, age)
        {
            this.Faculty = faculty;
            this.Course = course;
        }
        
        public Student(
            string name, string gender, int age, int weight, int height, string faculty, int course, int specialty)
            : base(name, gender, age)
        {
            this.Faculty = faculty;
            this.Course = course;
            this.Specialty = specialty;
        }
        
        public Student(string name, string gender, int age, 
            int weight, int height, string faculty, int course, int specialty, int score)
            : base(name, gender, age)
        {
            this.Faculty = faculty;
            this.Course = course;
            this.Specialty = specialty;
            this.Score = score;
        }
        
        
        public string GetStudentInfo()
        {
            return $"\nName: {Name} \nFaculty: {Faculty} \nCourse: {Course} \nSpecialty: {Specialty} \nScore: {Score}";
        }
        
        
        public override string GetInfo() 
        {
            return GetStudentInfo() + $"\nGender: {Gender} \nAge: {Age} ";
        }
    }
}