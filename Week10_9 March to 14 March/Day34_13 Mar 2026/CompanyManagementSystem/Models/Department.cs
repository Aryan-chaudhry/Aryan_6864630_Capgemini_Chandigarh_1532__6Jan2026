using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CompanyManagementSystem.Models
{
    public class Department
    {
		public int DepartmentId { get; set; }

		public string Name { get; set; }

		public int CompanyId { get; set; }
		[ValidateNever]
		public Company Company { get; set; }

		[ValidateNever]
		public ICollection<Employee> Employees { get; set; }
	}
}
