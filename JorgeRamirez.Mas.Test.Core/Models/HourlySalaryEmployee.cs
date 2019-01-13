namespace JorgeRamirez.Mas.Test.Core.Models
{
    public class HourlySalaryEmployee : Employee
    {
        public override void CalculateAnnualSalary()
        {
            AnnualSalary = (120 * HourlySalary) * 12;
        }
    }
}