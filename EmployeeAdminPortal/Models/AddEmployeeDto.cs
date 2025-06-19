namespace EmployeeAdminPortal.Models
{
    public class AddEmployeeDto
    {

        public required string IdNumber { set; get; }
        public required string Name { set; get; }
        public string? Surname { set; get; }
        public string? Gender { set; get; }
        public string? phone { set; get; }
        public required string Email { set; get; }
        public required decimal Salary { get; set; }
    }
}
