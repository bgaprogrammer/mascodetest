using System.Collections.Generic;
using System.Linq;
using JorgeRamirez.MasTest.Core.Dal;
using JorgeRamirez.MasTest.Core.Models;

namespace JorgeRamirez.MasTest.Core.Bl
{
    public static class EmployeeBl
    {
        public static List<Employee> GetEmployees(RestEndPointModel model, int employeeId = 0)
        {
            var employees = RestServiceManager.GetEmployees(model);

            if (employeeId > 0)
                FilterEmployee(ref employees, employeeId);

            CalculateAnnualSalary(ref employees);

            return employees;
        }

        private static void FilterEmployee(ref List<Employee> employees, int employeeId)
        {
            var employee = employees.FirstOrDefault(x => x.Id.Equals(employeeId));

            employees = (employee != null) ? new List<Employee> { employee } : new List<Employee>();
        }

        private static void CalculateAnnualSalary(ref List<Employee> employees)
        {
            employees.ForEach(x => x.CalculateAnnualSalary());
        }
    }
}