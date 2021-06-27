using System.Collections.Generic;
using University.Interfaces;
using University.Models;

namespace University.Mocks
{
    public class MockFaculty : IFaculty
    {
        public IEnumerable<Faculty> Faculties
        {
            get
            {
                return new List<Faculty>
                {
                    new Faculty { Id = 1, Name = "FICT", InstituteId = 1, Students = new List<Student>() },
                    new Faculty { Id = 2, Name = "IASA", InstituteId = 1, Students = new List<Student>() }
                };
            }
        }
    }
}
