using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    new Institute { Id = 2, Name = "HPI"}
                };
            }
        }
    }
}
