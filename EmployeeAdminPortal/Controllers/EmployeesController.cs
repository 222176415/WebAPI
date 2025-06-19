using EmployeeAdminPortal.Database;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entities;
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
        //    string EmployeIdNumber = Employee.IdNumber;
        //    var Employees = dbContext.Employees.Find(EmployeIdNumber === IdNumber);

        //    if (Employees == null) {
        //        return NotFound();
        //    }
        //    return Ok(Employees);
        //}



        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployee)
        {

            var employeeEntity = new Employee()
            {
                Name = addEmployee.Name,
                Surname = addEmployee.Surname,
                IdNumber = addEmployee.IdNumber,
                Email = addEmployee.Email,
                Gender = addEmployee.Gender,
                Salary = addEmployee.Salary,

            };


        dbContext.Employees.Add(employeeEntity);
        dbContext.SaveChanges();
            return Ok(employeeEntity);
        }
    }
}
