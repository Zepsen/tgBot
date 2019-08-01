using Microsoft.EntityFrameworkCore;

namespace Bot.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {

        }

        public ApplicationContext(DbContextOptions options)
            : base(options)
        {

        }

    }
}
