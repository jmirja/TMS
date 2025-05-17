using TMS.Domain.Entities;

namespace TMS.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
