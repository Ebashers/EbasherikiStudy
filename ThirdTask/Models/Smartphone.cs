using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Models
{
    class Smartphone : Telephone
    {
        public int Ram { get; set; }
        public Smartphone(int year) : base(year)
        {
        }

        public override string Call(string callVar)
        {
            return base.Call(callVar) + "hui";
        }

        //public override string Charge(string chargeVar)
        //{
        //    chargeVar = "4000mAc";
        //    return chargeVar;
        //}
    }
}
