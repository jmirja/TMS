using TMS.Domain.Entities;

namespace TMS.Domain.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}
