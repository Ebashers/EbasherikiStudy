using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Models
{
    abstract class Telephone
    {
        // блять нахуй сука піздєц я не понімаю як з цією хуйнею работать, нахуя тут ктор, нада тут ктор, шо, куда блять, єбаний рот
        public abstract string Call();
        public abstract string Charge();
        public Telephone(string _Call, string _Charge)
        {
            _Call = Call().ToString();
            _Charge = Charge().ToString();
        }
    }
}
