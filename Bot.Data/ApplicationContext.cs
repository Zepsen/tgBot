using Microsoft.EntityFrameworkCore;

namespace Bot.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        public ApplicationContext()
        {

        }

        public ApplicationContext(DbContextOptions options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsersItems>()
                .HasKey(i => new { i.UserId, i.ItemId });

            modelBuilder.Entity<UsersItems>()
                .HasOne(ut => ut.Item)
                .WithMany(b => b.UsersTasks)
                .HasForeignKey(ut => ut.ItemId);

            modelBuilder.Entity<UsersItems>()
                .HasOne(ut => ut.User)
                .WithMany(c => c.UsersItems)
                .HasForeignKey(ut => ut.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
