using System.Collections.Generic;
using JorgeRamirez.MasTest.Core.Models;
using Newtonsoft.Json;

namespace JorgeRamirez.MasTest.Core.Infrastructure
{
    public static class ExtMethods
    {
        public static List<Employee> ToEmployeeList(this string jsonString)
        {
            return JsonConvert.DeserializeObject<List<Employee>>(jsonString);
        }
    }
}