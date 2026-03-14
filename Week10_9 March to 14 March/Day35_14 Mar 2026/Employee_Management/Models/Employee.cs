using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Employee_Management.Models
{
    public class Employee
    {
		public int EmployeeId { get; set; }

		public string Name { get; set; }

		public int DepartmentId { get; set; }

		[ValidateNever]
		public Department Department { get; set; }

		[ValidateNever]
		public ICollection<EmployeeProject> EmployeeProjects { get; set; }
	}
}
