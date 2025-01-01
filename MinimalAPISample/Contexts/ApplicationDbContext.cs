using Microsoft.EntityFrameworkCore;

namespace MinimalAPISample.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
