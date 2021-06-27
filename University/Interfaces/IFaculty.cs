using System.Collections.Generic;
using University.Models;

namespace University.Interfaces
{
    public interface IFaculty
    {
        IEnumerable<Faculty> Faculties { get; }
    }
}
