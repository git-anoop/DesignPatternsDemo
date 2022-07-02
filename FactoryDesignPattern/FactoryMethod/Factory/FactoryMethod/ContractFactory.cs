using Common.Models;
using FactoryDesignPattern.FactoryMethod.Base;


namespace FactoryDesignPattern.FactoryMethod.Factory.FactoryMethod
{
    public class ContractFactory : EmployeeBaseFactory
    {
        public ContractFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeBase Create()
        {
            ContractEmployee contractEmployee = new ContractEmployee();
            _employee.TravelAllowance = contractEmployee.GetTravelAllowance();

            return contractEmployee;
        }
    }
}
