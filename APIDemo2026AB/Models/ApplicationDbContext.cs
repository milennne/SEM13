using Microsoft.EntityFrameworkCore;

namespace APIDemo2026AB.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
           DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Pay> Pays { get; set; }
    }
}
