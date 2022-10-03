using ApiRedarbor.Interfaces;
using ApiRedarbor.Logica;
using ApiRedarbor.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace ApiRedarbor.Controllers
{
    [ApiController]
    public class RedarborController : Controller
    {
        private readonly IEmployee iEmployee = new EmployeeLogica();

        [HttpGet]
        [Route("api/redarbor")]
        public IActionResult Get()
        {
            Response getEmployees = iEmployee.GetEmployees();
            return Ok(getEmployees);
        }

        [HttpGet]
        [Route("api/redarbore/{id}")]
        public IActionResult Get(int id)
        {
            Response getEmployeeById = iEmployee.GetEmployee(id);
            return Ok(getEmployeeById);
        }

        [HttpPost]
        [Route("api/redarbor")]
        public IActionResult Post(Employee employee)
        {
            Response postEmployee = iEmployee.PostEmployee(employee);
            return Ok(postEmployee);
        }

        [HttpPut]
        [Route("api/redarbor/{id}")]
        public IActionResult Put(int id, Employee employee)
        {
            Response putEmployee = iEmployee.PutEmployee(id, employee);
            return Ok(putEmployee);
        }

        [HttpDelete]
        [Route("api/redarbor/{id}")]
        public IActionResult Delete(int id)
        {
            Response deleteEmployee = iEmployee.DeleteEmployee(id);
            return Ok(deleteEmployee);
        }
    }
}
