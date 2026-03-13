using Microsoft.Identity.Client;

namespace CompanyManagementSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public decimal Salary { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

       
    }
}
