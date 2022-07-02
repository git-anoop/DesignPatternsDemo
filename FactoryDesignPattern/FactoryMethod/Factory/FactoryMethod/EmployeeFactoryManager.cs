using Common.Models;

namespace FactoryDesignPattern.FactoryMethod.Factory.FactoryMethod
{
    public class EmployeeFactoryManager
    {
        public EmployeeBaseFactory CreateFactory(Employee emp)
        {
            EmployeeBaseFactory returnValue = null;

            switch (emp.EmployeeType)
            {
                case 1:
                    returnValue = new PermanentFactory(emp);
                    break;
                case 2:
                    returnValue = new ContractFactory(emp);
                    break;
            }

            return returnValue;
        }
    }
}
