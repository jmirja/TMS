using Microsoft.Extensions.DependencyInjection;
using TMS.Application.Interfaces;
using TMS.Domain.Entities;
using TMS.Domain.Enums;

namespace TMS.Infastructure.Persistence
{
    public static class DbSeeder
    {
        public static async Task SeedUsersAsync(IServiceProvider provider)
        {
            using var scope = provider.CreateScope();
            var repo = scope.ServiceProvider.GetRequiredService<IUserRepository>();

            var defaultUsers = new[]
            {
            new User
            {
                Id = Guid.NewGuid(),
                FullName = "Admin User",
                Email = "admin@demo.com",
                Role = UserRole.Admin,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin123!")
            },
            new User
            {
                Id = Guid.NewGuid(),
                FullName = "Manager User",
                Email = "manager@demo.com",
                Role = UserRole.Manager,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("Manager123!")
            },
            new User
            {
                Id = Guid.NewGuid(),
                FullName = "Employee User",
                Email = "employee@demo.com",
                Role = UserRole.Employee,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("Employee123!")
            }
        };

            foreach (var user in defaultUsers)
            {
                if (await repo.GetUserByEmailAsync(user.Email) is null)
                    await repo.AddUserAsync(user);
            }
        }
    }

}
