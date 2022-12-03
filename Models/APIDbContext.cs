using Microsoft.EntityFrameworkCore;

namespace DotNet6WebAPI.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions option):base(option)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
