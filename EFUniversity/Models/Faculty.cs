using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUniversity.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Institute Institute { get; set; }
        public int InstituteId { get; set; }
        public List<Student> Students { get; set; }
    }
}
