using Microsoft.EntityFrameworkCore;
using TMS.Domain.Entities;

namespace TMS.Infastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<User> Users => Set<User>();
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
        }
    }
}
