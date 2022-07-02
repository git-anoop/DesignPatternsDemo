using Common.Models;
using FactoryDesignPattern.FactoryMethod.Base;

namespace FactoryDesignPattern.FactoryMethod.Factory.FactoryMethod
{
    public class PermanentFactory : EmployeeBaseFactory
    {
        public PermanentFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeBase Create()
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee();
            _employee.MedicalAllowance = permanentEmployee.GetMedicalAllowance();
            return permanentEmployee;
        }
    }
}
