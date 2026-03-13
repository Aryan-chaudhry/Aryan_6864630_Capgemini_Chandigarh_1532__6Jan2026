using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyManagementSystem.Models
{
    [Table("tblCompany")]
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Department>  Departments { get; set; }
		public ICollection<Project> Projects { get; set; }
	}
}
