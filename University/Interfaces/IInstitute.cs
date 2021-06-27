using System.Collections.Generic;
using University.Models;

namespace University.Interfaces
{
    public interface IInstitute
    {
        IEnumerable<Institute> Institutes { get; }
    }
}
