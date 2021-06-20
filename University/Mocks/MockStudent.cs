using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Interfaces;
using University.Models;

namespace University.Mocks
{
    public class MockStudent : IStudent
    {
        public IEnumerable<Student> Students
        {
            get
            {
                return new List<Student>
                {
                    new Student
                    {
                        Name = "Eban",
                        Surname = "Yebanovich",
                        GradebookId = 0301,
                        GPA = 70.2
                    },
                    new Student
                    {
                        Name = "Pidr",
                        Surname = "Pidrilovich",
                        GradebookId = 0302,
                        GPA = 95.6
                    }
                };
            }
        }

        public Student GetStudent(int StudentId)
        {
            throw new NotImplementedException();
        }
    }
}
