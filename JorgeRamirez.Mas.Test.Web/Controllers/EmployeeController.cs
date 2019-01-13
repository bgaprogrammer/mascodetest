using DataTables.Queryable;
using JorgeRamirez.Mas.Test.Core.Bl;
using JorgeRamirez.Mas.Test.Core.Models;
using System.Configuration;
using System.Linq;
using System.Web.Http;

namespace JorgeRamirez.Mas.Test.Web.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        [Route("{id:int?}")]
        [HttpPost]
        public IHttpActionResult GetEmployees([FromBody] DataTablesAjaxPostModel model, [FromUri] int id = 0)
        {
            var restInfo = new RestEndPointModel(ConfigurationManager.AppSettings["MasApiBaseUrl"], ConfigurationManager.AppSettings["MasApiEmployeesResource"]);

            var employees = EmployeeBl.GetEmployees(restInfo, id);

            return Ok(new
            {
                draw = model.Draw,
                recordsTotal = employees.Count(),
                recordsFiltered = employees.Count(),
                data = employees
            });
        }
   }
}