using Common.Models;
using FactoryDesignPattern.AbstractFactory;
using FactoryDesignPattern.FactoryMethod.Factory.FactoryMethod;
using FactoryDesignPattern.SimpleFactory.Base;
using FactoryDesignPattern.SimpleFactory.Factory;
using System;

namespace FactoryDesignPattern
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

            ////Simple factory
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Simple factory");            
            EmployeeFactory factory = new EmployeeFactory();
            IEmployeeBase result = factory.GetEmployeeFactory(employee.EmployeeType);
            Console.WriteLine("Hourly Wages: {0}", result.GetHourlyWages().ToString());
            Console.WriteLine("Yearly Bonus: {0}", result.GetYearlyBonus().ToString());

            ////Factory Method
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Factory Method");
            EmployeeBaseFactory factoryMethod = new EmployeeFactoryManager().CreateFactory(employee);
            factoryMethod.ApplySalary();

            Console.WriteLine("Hourly Wages: {0}", employee.HourlyWages.ToString());
            Console.WriteLine("Yearly Bonus: {0}", employee.YearlyBonus.ToString());
            if (employee.MedicalAllowance != 0)
            {
                Console.WriteLine("Medical allowance: {0}", employee.MedicalAllowance.ToString());
            }

            if (employee.TravelAllowance != 0)
            {
                Console.WriteLine("Travel allowance: {0}", employee.TravelAllowance.ToString());
            }

            ////Abstract Factory Method
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Abstract Factory Method");            
            IComputerFactory computerFactory = new EmployeeSystemFactory().Create(employee);
            EmployeeSystemManager manager = new EmployeeSystemManager(computerFactory);
            employee.ComputerDetails = manager.GetSystemDetails();
            Console.WriteLine("System Details: {0}", employee.ComputerDetails);
        }
    }
}
