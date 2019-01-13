using JorgeRamirez.Mas.Test.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JorgeRamirez.Mas.Test.Core.Infrastructure
{
    public static class ExtMethods
    {
        public static List<Employee> ToEmployeeList(this string jsonString)
        {
            return JsonConvert.DeserializeObject<List<Employee>>(jsonString);
        }
    }
}