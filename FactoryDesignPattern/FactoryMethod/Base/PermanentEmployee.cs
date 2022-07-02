
namespace FactoryDesignPattern.FactoryMethod.Base
{
    public class PermanentEmployee : IEmployeeBase
    {
        public double GetHourlyWages()
        {
            return 100;
        }

        public double GetYearlyBonus()
        {
            return 5000;
        }

        public  double GetMedicalAllowance()
        {
            return 100000;
        }
    }
}
