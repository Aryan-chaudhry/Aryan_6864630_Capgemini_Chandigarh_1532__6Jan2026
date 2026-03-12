using Microsoft.EntityFrameworkCore;
using University_Management_System.Models;

namespace University_Management_System.Data
{
    public class UniversityManagementDBcontext:DbContext
    {
        public UniversityManagementDBcontext(DbContextOptions<UniversityManagementDBcontext>options) : base(options)
        {

        }

        public DbSet<StudentModel> students { get; set; }
        public DbSet<CourseModel> courses { get; set; }
        public DbSet<DepartmentModel> departments { get; set; }
        public DbSet<EnrollmentModel> enrollments { get; set; }
        public DbSet<InstructorModel> instructors { get; set; }




    }
}
