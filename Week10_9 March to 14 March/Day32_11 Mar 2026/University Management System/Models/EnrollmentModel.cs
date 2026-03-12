using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System.Models
{
    [Table("tblEnrollment")]
    public class EnrollmentModel
    {
        [Key]
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public string Grade { get; set; }
    }
}
