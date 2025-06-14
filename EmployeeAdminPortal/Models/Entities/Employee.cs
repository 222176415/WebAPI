using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        public  Guid EmployeeId { set; get; }
        public required string IdNumber { set; get; }
        public required string  Name { set; get; }
        public string? Surname{ set; get; }
        public string? Gender { set; get; }
        public required string  Email { set; get; }
        public required decimal Salary { get; set; }
    }
}
