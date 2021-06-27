using System.Collections.Generic;
using University.Interfaces;
using University.Models;

namespace University.Mocks
{
    public class MockInstitute : IInstitute
    {
        public IEnumerable<Institute> Institutes
        {
            get
            {
                return new List<Institute>
                {
                    new Institute { Id = 1, Name = "KPI", Faculties = new List<Faculty>()},
                };
            }
        }
    }
}
