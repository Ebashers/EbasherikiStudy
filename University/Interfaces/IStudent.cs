using System.Collections.Generic;
using University.Models;

namespace University.Interfaces
{
    public interface IStudent
    {
        IEnumerable<Student> Students { get; }
        Student GetStudent(int StudentId);
    }
}
