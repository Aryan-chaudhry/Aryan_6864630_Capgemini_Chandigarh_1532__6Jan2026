using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Employee_Management.Models
{
    public class Department
    {
		public int DepartmentId { get; set; }

		public string DepartmentName { get; set; }

		[ValidateNever]
		public ICollection<Employee> Employees { get; set; }
	}
}
