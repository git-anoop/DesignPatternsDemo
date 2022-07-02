using Common.Models;
using FactoryDesignPattern.FactoryMethod.Base;

namespace FactoryDesignPattern.FactoryMethod.Factory.FactoryMethod
{
    public abstract class EmployeeBaseFactory
    {
        protected Employee _employee;
        public EmployeeBaseFactory(Employee emp)
        {
            _employee = emp;
        }

        public Employee ApplySalary()
        {
            IEmployeeBase manager = this.Create();

            _employee.HourlyWages = manager.GetHourlyWages();
            _employee.YearlyBonus = manager.GetYearlyBonus();

            return _employee;
        }

        public abstract IEmployeeBase Create();
    }
}
