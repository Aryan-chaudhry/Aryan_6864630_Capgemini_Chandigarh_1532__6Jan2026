using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System.Models
{
    [Table("tblCourse")]
    public class CourseModel
    {
        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; }

        public string Credit { get; set; }


    }
}
