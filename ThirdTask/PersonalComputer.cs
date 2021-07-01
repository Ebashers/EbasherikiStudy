namespace ThirdTask
{
    public class PersonalComputer : Device
    {
        public int GraphicCardCount { get; init; }
        public bool WaterCooling { get; init; }
        public int CPUCoreCount { get; init; }
        
        public  PersonalComputer() {}
        
        public PersonalComputer(string company, string model, int price, int graphicCardCount, bool waterCooling, int cpuCoreCount) :
            base(company, model, price)
        {
            GraphicCardCount = graphicCardCount;
            WaterCooling = waterCooling;
            CPUCoreCount = cpuCoreCount;
        }


        private string GetPCInfo()
        {
            return $"\nGraphic cards count: {GraphicCardCount} \nWater cooling system: {WaterCooling} \nCPU's core count: {CPUCoreCount}";
        }

        public override string GetInfo()
        {
            return $"\nCompany: {Company} \nModel: {Model} \nPrice: {Price}" + GetPCInfo();
        }
    }
}