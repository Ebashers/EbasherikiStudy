using System;

namespace ThirdTask
{
    public class Device
    {
        public string Company { get; init; } = "Unknown";
        public string Model { get; init; } = "Undefined";
        public int Price { get; init; }
        public Device() {}

        protected Device(string company)
        {
            Company = company;
        }

        private Device(string company, string model): this(company)
        {
            Model = model;
        }

        protected Device(string company, string model, int price) : this(company, model)
        {
             Price = price;
        }

        public virtual string GetInfo()
        { 
            return ($"\nCompany: {Company} \nModel: {Model} \nPrice: {Price}");
        }       
    }
}
