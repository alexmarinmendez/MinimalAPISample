using Microsoft.EntityFrameworkCore;
using MinimalAPISample.Entities;

namespace MinimalAPISample.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
