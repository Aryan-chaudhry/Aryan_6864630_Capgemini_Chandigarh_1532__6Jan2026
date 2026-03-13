namespace CompanyManagementSystem.Models
{
    public class Project
    {
		public int ProjectId { get; set; }

		public string ProjectName { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public int CompanyId { get; set; }

		public Company Company { get; set; }
	}
}
