using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University.Interfaces
{
    public interface IStudent
    {
        IEnumerable<Student> Students { get; }
        Student GetStudent(int StudentId);
    }
}
