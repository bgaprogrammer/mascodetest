namespace JorgeRamirez.MasTest.Core.Models
{
    public class HourlySalaryEmployee : Employee
    {
        public override void CalculateAnnualSalary()
        {
            AnnualSalary = (120 * HourlySalary) * 12;
        }
    }
}