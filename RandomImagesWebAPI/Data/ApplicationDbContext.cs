using Microsoft.EntityFrameworkCore;

namespace RandomImagesWebAPI.Models
{
    /// <summary>
    /// This is the application database context
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<About> About { get; set; }
    }
}
