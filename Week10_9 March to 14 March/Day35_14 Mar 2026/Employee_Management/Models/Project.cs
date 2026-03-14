using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Employee_Management.Models
{
    public class Project
    {
		public int ProjectId { get; set; }

		public string Title { get; set; }

		[ValidateNever]
		public ICollection<EmployeeProject> EmployeeProjects { get; set; }
	}

}

