using System;
using JorgeRamirez.Mas.Test.Core.Bl;
using JorgeRamirez.Mas.Test.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JorgeRamirez.Mas.Test.Utest
{
    [TestClass]
    public class GetEmployeesTest
    {
        readonly string BaseUrl = "http://masglobaltestapi.azurewebsites.net/api/";
        readonly string EmployeeRes = "Employees";

        [TestMethod]
        public void WhenEmployeeIdDontExistsTheReturnedListMustBeEmpty()
        {
            var restInfo = new RestEndPointModel(BaseUrl, EmployeeRes);

            var rnd = new Random(888);
            var id = rnd.Next(888, 99999);

            var employee = EmployeeBl.GetEmployees(restInfo, id);

            Assert.AreEqual(0, employee.Count);
        }
    }
}