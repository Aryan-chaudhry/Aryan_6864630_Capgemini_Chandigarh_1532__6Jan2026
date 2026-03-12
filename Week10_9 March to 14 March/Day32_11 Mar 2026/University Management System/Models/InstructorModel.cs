using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace University_Management_System.Models
{
    [Table("tblInstructor")]
    public class InstructorModel
    {
        [Key]
        public int InstructorId { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }


    }
}
