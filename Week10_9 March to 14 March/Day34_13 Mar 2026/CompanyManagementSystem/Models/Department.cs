namespace CompanyManagementSystem.Models
{
    public class Department
    {
		public int DepartmentId { get; set; }

		public string Name { get; set; }

		public int CompanyId { get; set; }

		public Company Company { get; set; }

		public ICollection<Employee> Employees { get; set; }
	}
}
