using Common.Models;

namespace FactoryDesignPattern.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee emp)
        {
            IComputerFactory returnValue = null;

            switch (emp.EmployeeType)
            {
                case 1:
                    if (emp.Designation == "Manager")
                    {
                        returnValue = new MacLaptopFactory();
                    }
                    else
                    {
                        returnValue = new MacDesktopFactory();
                    }
                    break;

                case 2:
                    if(emp.Designation == "Manager")
                    {
                        returnValue = new DellLaptopFactory();
                    }
                    else
                    {
                        returnValue = new DellDesktopFactory();
                    }
                    break;
            }

            return returnValue;
        }
    }
}
