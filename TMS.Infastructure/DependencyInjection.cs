using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TMS.Domain.Interfaces;
using TMS.Infrastructure.Auth;
using TMS.Infrastructure.Persistence;
using TMS.Infrastructure.Repositories;

namespace TMS.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IJwtService, JwtService>();

            return services;
        }
    }
}


