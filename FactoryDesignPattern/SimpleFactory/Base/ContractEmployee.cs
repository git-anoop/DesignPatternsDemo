
namespace FactoryDesignPattern.SimpleFactory.Base
{
    public class ContractEmployee : IEmployeeBase
    {
        public double GetHourlyWages()
        {
            return 150;
        }

        public double GetYearlyBonus()
        {
            return 2500;
        }
    }
}
