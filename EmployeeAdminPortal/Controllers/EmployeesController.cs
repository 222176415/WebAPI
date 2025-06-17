using EmployeeAdminPortal.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    //localhost/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        //private field that will be used for interaction
        private readonly ApplicationDbContext dbContext;


        //inject DB Context to interact with the DB
        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmployees = dbContext.Employees.ToList();
            return Ok(allEmployees);
        }

        //[HttpGet]
        //public IActionResult GetAllEmployeeById(int IdNumber)
        //{
            //var Employees = dbContext.Employees.Find(Employees.IdNumber === IdNumber);

            //if (Employees == null) {
                //return NotFound()
            //return Ok(allEmployees);
        //}
    }
}
