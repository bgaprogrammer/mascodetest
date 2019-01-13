using JorgeRamirez.Mas.Test.Core.Models;
using RestSharp;
using System.Collections.Generic;
using JorgeRamirez.Mas.Test.Core.Infrastructure;

namespace JorgeRamirez.Mas.Test.Core.Dal
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