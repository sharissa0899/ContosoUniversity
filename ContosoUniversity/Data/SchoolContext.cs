using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
// create a DBSET property for each entity set. 
//An entity set typically corresponds to a database table.
//An entity corresponds to a row in the table.
namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}