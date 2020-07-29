using Newtonsoft.Json;
using Refactorius.Extensions.JsonSubTypes;

namespace JorgeRamirez.MasTest.Core.Models
{
    [JsonConverter(typeof(JsonSubtypes), "ContractTypeName")]
    [JsonSubtypes.KnownSubType(typeof(HourlySalaryEmployee), "HourlySalaryEmployee")]
    [JsonSubtypes.KnownSubType(typeof(MonthlySalaryEmployee), "MonthlySalaryEmployee")]
    public abstract class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ContractTypeName { get; set; }

        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string RoleDescription { get; set; }

        public int HourlySalary { get; set; }

        public int MonthlySalary { get; set; }

        public int AnnualSalary { get; set; }

        public abstract void CalculateAnnualSalary();
    }
}