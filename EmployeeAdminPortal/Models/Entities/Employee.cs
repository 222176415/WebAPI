using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        public  Guid Id { set; get; }
        public required string  name { set; get; }
        public string? surname{ set; get; }
        public required string  email { set; get; }
        public required decimal salary { get;set }
    }
}
