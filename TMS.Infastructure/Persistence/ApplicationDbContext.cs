using Microsoft.EntityFrameworkCore;
using TMS.Domain.Entities;

namespace TMS.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<User> Users => Set<User>();
        public DbSet<Team> Teams => Set<Team>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.FullName)
                    .IsRequired()
                    .HasMaxLength(100);
                e.HasIndex(x => x.Email)
                    .IsUnique();
                e.Property(x => x.Email)
                    .IsRequired()
                    .HasMaxLength(100);
                e.Property(x => x.PasswordHash)
                    .IsRequired();
                e.Property(x => x.Role)
                    .IsRequired();
            });

            modelBuilder.Entity<Team>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                e.Property(x => x.Description)
                    .HasMaxLength(500);
            });
        }
    }
}
