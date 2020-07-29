using System.Collections.Generic;
using JorgeRamirez.MasTest.Core.Infrastructure;
using JorgeRamirez.MasTest.Core.Models;
using RestSharp;

namespace JorgeRamirez.MasTest.Core.Dal
{
    public static class RestServiceManager
    {
        public static List<Employee> GetEmployees(RestEndPointModel model)
        {
            var client = new RestClient(model.BaseUrl);

            var request = new RestRequest(model.EmployeeResName, Method.GET);

            var response = client.Execute(request);

            return response.Content.ToEmployeeList();
        }
    }
}