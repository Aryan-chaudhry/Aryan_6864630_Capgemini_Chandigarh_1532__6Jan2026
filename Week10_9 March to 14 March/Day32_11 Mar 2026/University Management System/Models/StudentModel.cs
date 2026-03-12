using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System.Models
{
    [Table("Student")]
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public DateOnly EnrollmentDate { get; set; }
    }
}
