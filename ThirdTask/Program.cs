using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var device = new Device() {Company = "Apple.Inc", Model = "Iphone 12", Price = 950};
            var nb1 = new Notebook() {Company= "MSI", Model ="GE63 Raider", Price = 2550, RgbKeyboard = true,WebCam = true,USBPorts = 3};
            var nb2 = new Notebook() {Company = "Xiaomi", Model = "RedmiNote", Price = 600};
            var nb3 = new Notebook() {RgbKeyboard = true,WebCam = false, USBPorts = 100};
            var pc1 = new PersonalComputer() {Company = "Invasion Labs", Model = "Revolt RS", Price = 2000, GraphicCardCount = 2, 
                WaterCooling = true,CPUCoreCount = 6};
            var device2 = new PersonalComputer() { };
            Console.WriteLine(device.GetInfo());
            Console.WriteLine(device2.GetInfo());
            Console.WriteLine(nb1.GetInfo());
            Console.WriteLine(nb2.GetInfo());
            Console.WriteLine(nb3.GetNoteookInfo());
            Console.WriteLine(pc1.GetInfo());
        }
    }
}