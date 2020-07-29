using System;
using JorgeRamirez.MasTest.Core.Bl;
using JorgeRamirez.MasTest.Core.Models;
using Xunit;

namespace JorgeRamirez.MasTest.Tests
{
    public class GetEmployeesTest
    {
        readonly string BaseUrl = "http://masglobaltestapi.azurewebsites.net/api/";
        readonly string EmployeeRes = "Employees";
        
        [Fact]
        public void WhenEmployeeIdDontExistsTheReturnedListMustBeEmpty()
        {
            var restInfo = new RestEndPointModel(BaseUrl, EmployeeRes);

            var rnd = new Random(888);
            var id = rnd.Next(888, 99999);

            var employee = EmployeeBl.GetEmployees(restInfo, id);
            
            Assert.Empty(employee);
        }
    }
}