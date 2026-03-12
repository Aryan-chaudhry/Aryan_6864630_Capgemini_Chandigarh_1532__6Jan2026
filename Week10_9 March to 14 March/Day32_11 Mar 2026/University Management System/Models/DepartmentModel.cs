using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System.Models
{
    [Table("tblDepartment")]
    public class DepartmentModel
    {
        [Key]
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public int Budget { get; set; }

    }
}
