using FactoryDesignPattern.SimpleFactory.Base;

namespace FactoryDesignPattern.SimpleFactory.Factory
{
    public class EmployeeFactory
    {
        public IEmployeeBase GetEmployeeFactory(int type)
        {
            IEmployeeBase returnValue = null;

            switch(type)
            {
                case 1: returnValue = new PermanentEmployee();
                    break;
                case 2: returnValue = new ContractEmployee();
                    break;
            }

            return returnValue;
        }
    }
}
