namespace JorgeRamirez.MasTest.Core.Models
{
    public class MonthlySalaryEmployee : Employee
    {
        public override void CalculateAnnualSalary()
        {
            AnnualSalary = (MonthlySalary * 12);
        }
    }
}