
namespace Common.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int EmployeeType { get; set; }
        public double HourlyWages { get; set; }
        public double YearlyBonus { get; set; }
        public double MedicalAllowance { get; set; }
        public double TravelAllowance { get; set; }
        public string ComputerDetails { get; set; }

        public string Designation { get; set; }
    }
}
