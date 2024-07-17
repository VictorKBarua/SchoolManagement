using Microsoft.EntityFrameworkCore;
namespace SchoolManagement.Repository
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }
        public DbSet<Domain.Student> Student { get; set; }
    }
}
