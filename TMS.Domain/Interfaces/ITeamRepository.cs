using TMS.Domain.Entities;

namespace TMS.Domain.Interfaces
{
    public interface ITeamRepository
    {
        Task<IEnumerable<Team>> GetAllAsync();
        Task<Team?> GetByIdAsync(Guid id);
        Task AddAsync(Team team);
        Task UpdateAsync(Team team);
        Task DeleteAsync(Guid id);
    }
}
