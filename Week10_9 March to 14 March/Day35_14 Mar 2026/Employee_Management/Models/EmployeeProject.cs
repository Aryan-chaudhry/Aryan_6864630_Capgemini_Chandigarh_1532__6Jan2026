using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Employee_Management.Models
{
    public class EmployeeProject
    {
		public int EmployeeId { get; set; }

		[ValidateNever]
		public Employee Employee { get; set; }

		public int ProjectId { get; set; }

		[ValidateNever]
		public Project Project { get; set; }

		public DateTime AssignedDate { get; set; }
	}
}
