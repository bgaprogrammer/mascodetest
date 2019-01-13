namespace JorgeRamirez.Mas.Test.Core.Models
{
    public class RestEndPointModel
    {
        public string BaseUrl { get; private set; }

        public string EmployeeResName { get; private set; }

        public RestEndPointModel(string baseUrl, string employeeRes)
        {
            BaseUrl = baseUrl;
            EmployeeResName = employeeRes;
        }
    }
}