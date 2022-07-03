using BuilderDesignPattern.ConcreteBuilder;
using BuilderDesignPattern.Product;
using Common.Models;
using Newtonsoft.Json;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            var systemInputs = new SystemConfiguration();

            Console.WriteLine("Select Device type: 1. Laptop 2. Desktop");
            var deviceType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select System RAM: 1. 4GB 2. 8GB");
            systemInputs.RAM = Convert.ToInt32(Console.ReadLine()) == 1 ? "4GB" : "8GB";
            Console.WriteLine("Select System HDD: 1. 512GB 2. 1TB");
            systemInputs.HDD = Convert.ToInt32(Console.ReadLine()) == 1 ? "512GB" : "1TB";
            if (deviceType == 2)
            {
                Console.WriteLine("Select Mouse: 1. Wireless 2. USB");
                systemInputs.Mouse = Convert.ToInt32(Console.ReadLine()) == 1 ? "Wireless" : "USB";
                Console.WriteLine("Select Keyboard: 1. Wireless 2. USB");
                systemInputs.Keyboard = Convert.ToInt32(Console.ReadLine()) == 1 ? "Wireless" : "USB";
            }
            else
            {
                Console.WriteLine("Select Screen: 1. Normal 2. Touchscreen");
                systemInputs.Touchscreen = Convert.ToInt32(Console.ReadLine()) == 1 ? "Normal" : "Touchscreen";
            }

            var result = SystemBuilder.GetMachineConfig(deviceType, systemInputs);

            Console.WriteLine("Selected System configuration: {0}", JsonConvert.SerializeObject(result).ToString());

        }
    }
}
