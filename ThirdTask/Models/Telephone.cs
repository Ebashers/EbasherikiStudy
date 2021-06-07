using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Models
{
    class Telephone
    {
        //string callVar = "i will give you nightcall"
        // блять нахуй сука піздєц я не понімаю як з цією хуйнею работать, нахуя тут ктор, нада тут ктор, шо, куда блять, єбаний рот
        public Telephone(int year)
        {
            Year = year;
        }
        public int Year { get; private set; }
        public virtual string Call(string callVar)
        {
            return callVar;
        }
        //public abstract string Charge(string chargeVar = "1000mAc");
    }
}
