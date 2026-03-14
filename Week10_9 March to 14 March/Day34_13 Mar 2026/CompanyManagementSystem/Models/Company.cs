using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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
        [ValidateNever]
        public ICollection<Employee> Employees { get; set; }
        [ValidateNever]
        public ICollection<Department>  Departments { get; set; }
        [ValidateNever]
		public ICollection<Project> Projects { get; set; }
	}
}
