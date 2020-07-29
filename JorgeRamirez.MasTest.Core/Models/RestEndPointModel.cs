namespace JorgeRamirez.MasTest.Core.Models
{
    public class RestEndPointModel
    {
        public string BaseUrl { get; }

        public string EmployeeResName { get; }

        public RestEndPointModel(string baseUrl, string employeeRes)
        {
            BaseUrl = baseUrl;
            EmployeeResName = employeeRes;
        }
    }
}