using Microsoft.EntityFrameworkCore;

namespace DotNet6WebAPI.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
