using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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

        [ValidateNever]
        public Company Company { get; set; }
		
		public int DepartmentId { get; set; }
		[ValidateNever]
		public Department Department { get; set; }

       
    }
}
