using Common.Models;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Select Employee type: 1. Permanent 2. Contract");
            employee.EmployeeType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select Employee designation: 1. Manager 2. Non-Manager");            
            employee.Designation = Convert.ToInt32(Console.ReadLine()) == 1 ? "Manager" : "Non-Manager";
            Console.WriteLine("Select System RAM: 1. 4GB 2. 8GB");
            var RAM = Convert.ToInt32(Console.ReadLine()) == 1 ? "4GB" : "8GB";
            Console.WriteLine("Select System HDD: 1. 512GB 2. 1TB");
            var HDD = Convert.ToInt32(Console.ReadLine()) == 1 ? "512GB" : "1TB";

            var system = new SystemConfiguration(RAM, HDD);
            employee.SystemConfiguration = system.BuildSystem();
            Console.WriteLine("Selected System configuration: {0}", employee.SystemConfiguration);

        }
    }
}
